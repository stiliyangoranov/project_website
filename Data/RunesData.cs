using Newtonsoft.Json;

namespace project_website.Data
{
    public static class RunesData
    {
        public static List<Perk> Perks = new List<Perk>();

        public static void Load(string language)
        {
            var jsonString = File.ReadAllText($"wwwroot/lol/12.14.1/data/{language}/runesReforged.json");
            var jsonData = JsonConvert.DeserializeObject<List<Perk>>(jsonString);

            if (jsonData != null)
            {
                Perks = jsonData;
            }

        }

        public static string GetRuneIconPath(int mainRuneId, int subRuneId)
        {
            foreach (var perk in Perks)
            {
                if (perk.Id == mainRuneId)
                {
                    if (subRuneId > 0)
                    {
                        foreach (var slot in perk.Slots)
                        {

                            var rune = slot.Runes.Find(r => r.Id == subRuneId);
                            if (rune != null)
                            {
                                return rune.Icon;
                            }
                        }
                    }
                    else
                    {
                        return perk.Icon;
                    }
                }
            }
            return string.Empty;
        }
    }
    public class Perk
    {
        public int Id { get; set; }
        public string Key { get; set; } = default!;
        public string Icon { get; set; } = default!;
        public string Name { get; set; } = default!;
        public List<Slot> Slots { get; set; } = default!;
    }

    public class Slot
    {
        public List<Rune> Runes { get; set; } = default!;
    }

    public class Rune
    {
        public int Id { get; set; }
        public string Key { get; set; } = default!;
        public string Icon { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string ShortDesc { get; set; } = default!;
        public string LongDesc { get; set; } = default!;
    }
}
