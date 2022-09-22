using System.Net;
using project_website.Data;
using project_website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using project_website.Settings;

namespace project_website.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly string _xApiKey;
        public ProfileModel(IOptions<ApiSettings> apiSettings)
        {
            _xApiKey = apiSettings.Value.XApiKey;
        }

        public Profile Profile { get; set; } = default!;
        public List<League> Leagues { get; set; } = default!;
        public List<Match> Matches { get; set; } = default!;

        public async Task<IActionResult> OnGet(string region, string account)
        {
            RunesData.Load("en_US");
            SummonerData.Load("en_US");

            string profileUrl = $"https://localhost:7038/api/lol/profile/{region}/{account}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("XApiKey", _xApiKey);
                HttpResponseMessage profileResponse = await client.GetAsync(profileUrl);

                if (profileResponse.StatusCode == HttpStatusCode.OK)
                {
                    string profileJson = await profileResponse.Content.ReadAsStringAsync();
                    var profileJsonData = JsonConvert.DeserializeObject<Profile>(profileJson);

                    if (profileJsonData != null)
                    {
                        string leaguesUrl = $"https://localhost:7038/api/lol/leagues/{region}/{profileJsonData.Id}";
                        HttpResponseMessage leaguesResponse = await client.GetAsync(leaguesUrl);
                        string leaguesJson = await leaguesResponse.Content.ReadAsStringAsync();
                        var leaguesJsonData = JsonConvert.DeserializeObject<List<League>>(leaguesJson);

                        if (leaguesJsonData != null)
                        {
                            Leagues = leaguesJsonData;
                        }
                        else
                        {
                            Leagues = new List<League>();
                        }

                        Profile = profileJsonData;
                        Matches = await GetMatchDataAsync(region, Profile.Puuid);
                        return Page();
                    }
                }
                
                return RedirectToPage("Index", new { response = "No existing account has been found!" });
            }
        }

        public async Task<List<Match>> GetMatchDataAsync(string region, string puuid)
        {
            string matchesUrl = $"https://localhost:7038/api/lol/matches/{region}/{puuid}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("XApiKey", _xApiKey);
                HttpResponseMessage matchIdsResponse = await client.GetAsync(matchesUrl);

                if (matchIdsResponse.StatusCode == HttpStatusCode.OK)
                {
                    string matchesJson = await matchIdsResponse.Content.ReadAsStringAsync();
                    var matchesJsonData = JsonConvert.DeserializeObject<List<Match>>(matchesJson);

                    if (matchesJsonData != null)
                    {
                        return matchesJsonData.OrderByDescending(m => m.MatchEndTimestamp).ToList();
                    }
                }
                return new List<Match>();
            }
        }
    }
}
