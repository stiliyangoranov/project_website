using Newtonsoft.Json;

namespace project_website.Data
{
    public static class SummonerData
    {
        public static Summoner Summoner = new Summoner();

        public static void Load(string language)
        {
            var jsonString = File.ReadAllText($"wwwroot/lol/12.14.1/data/{language}/summoner.json");
            var jsonData = JsonConvert.DeserializeObject<Summoner>(jsonString);

            if (jsonData != null)
            {
                Summoner = jsonData;
            }
        }

        public static string GetSpellIconPath(string key)
        {
            if (Summoner.Data.SummonerBarrier.Key == key)
            {
                return Summoner.Data.SummonerBarrier.Image.Full;
            }
            else if (Summoner.Data.SummonerBoost.Key == key)
            {
                return Summoner.Data.SummonerBoost.Image.Full;
            }
            else if (Summoner.Data.SummonerDot.Key == key)
            {
                return Summoner.Data.SummonerDot.Image.Full;
            }
            else if (Summoner.Data.SummonerExhaust.Key == key)
            {
                return Summoner.Data.SummonerExhaust.Image.Full;
            }
            else if (Summoner.Data.SummonerFlash.Key == key)
            {
                return Summoner.Data.SummonerFlash.Image.Full;
            }
            else if (Summoner.Data.SummonerHaste.Key == key)
            {
                return Summoner.Data.SummonerHaste.Image.Full;
            }
            else if (Summoner.Data.SummonerHeal.Key == key)
            {
                return Summoner.Data.SummonerHeal.Image.Full;
            }
            else if (Summoner.Data.SummonerMana.Key == key)
            {
                return Summoner.Data.SummonerMana.Image.Full;
            }
            else if (Summoner.Data.SummonerPoroRecall.Key == key)
            {
                return Summoner.Data.SummonerPoroRecall.Image.Full;
            }
            else if (Summoner.Data.SummonerPoroThrow.Key == key)
            {
                return Summoner.Data.SummonerPoroThrow.Image.Full;
            }
            else if (Summoner.Data.SummonerSmite.Key == key)
            {
                return Summoner.Data.SummonerSmite.Image.Full;
            }
            else if (Summoner.Data.SummonerSnowURFSnowball_Mark.Key == key)
            {
                return Summoner.Data.SummonerSnowURFSnowball_Mark.Image.Full;
            }
            else if (Summoner.Data.SummonerSnowball.Key == key)
            {
                return Summoner.Data.SummonerSnowball.Image.Full;
            }
            else if (Summoner.Data.SummonerTeleport.Key == key)
            {
                return Summoner.Data.SummonerTeleport.Image.Full;
            }
            else if (Summoner.Data.Summoner_UltBookPlaceholder.Key == key)
            {
                return Summoner.Data.Summoner_UltBookPlaceholder.Image.Full;
            }
            else if (Summoner.Data.Summoner_UltBookSmitePlaceholder.Key == key)
            {
                return Summoner.Data.Summoner_UltBookSmitePlaceholder.Image.Full;
            }
            return string.Empty;
        }
    }
    public class Summoner
    {
        public string Type { get; set; } = default!;
        public Data Data { get; set; } = default!;
    }

    public class Data
    {
        public SummonerBarrier SummonerBarrier { get; set; } = default!;
        public SummonerBoost SummonerBoost { get; set; } = default!;
        public SummonerDot SummonerDot { get; set; } = default!;
        public SummonerExhaust SummonerExhaust { get; set; } = default!;
        public SummonerFlash SummonerFlash { get; set; } = default!;
        public SummonerHaste SummonerHaste { get; set; } = default!;
        public SummonerHeal SummonerHeal { get; set; } = default!;
        public SummonerMana SummonerMana { get; set; } = default!;
        public SummonerPoroRecall SummonerPoroRecall { get; set; } = default!;
        public SummonerPoroThrow SummonerPoroThrow { get; set; } = default!;
        public SummonerSmite SummonerSmite { get; set; } = default!;
        public SummonerSnowURFSnowball_Mark SummonerSnowURFSnowball_Mark { get; set; } = default!;
        public SummonerSnowball SummonerSnowball { get; set; } = default!;
        public SummonerTeleport SummonerTeleport { get; set; } = default!;
        public Summoner_UltBookPlaceholder Summoner_UltBookPlaceholder { get; set; } = default!;
        public Summoner_UltBookSmitePlaceholder Summoner_UltBookSmitePlaceholder { get; set; } = default!;
    }

    public class SummonerBarrier
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }

    public class SummonerBoost
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }

    public class SummonerDot
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerExhaust
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerFlash
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerHaste
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerHeal
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerMana
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerPoroRecall
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerPoroThrow
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerSmite
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerSnowURFSnowball_Mark
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerSnowball
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class SummonerTeleport
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class Summoner_UltBookPlaceholder
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }
    public class Summoner_UltBookSmitePlaceholder
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Tooltip { get; set; } = default!;
        public string Key { get; set; } = default!;
        public Image Image { get; set; } = default!;
    }


    public class Image
    {
        public string Full { get; set; } = default!;
        public string Sprite { get; set; } = default!;
        public string Group { get; set; } = default!;
    }
}
