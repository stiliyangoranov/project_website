namespace project_website.Models
{
    public class Participant
    {
        public string SummonerName { get; set; } = null!;
        public string Puuid { get; set; } = null!;
        public decimal Kda { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int PrimaryRuneStyle { get; set; }
        public int PrimaryRune { get; set; }
        public int SecondaryRuneStyle { get; set; }
        public int SecondaryRune { get; set; }
        public decimal VisionPerMinute { get; set; }
        public int CreepScore { get; set; }
        public decimal CreepScorePerMinute { get; set; }
        public int TotalDamageToChampions { get; set; }
        public decimal DamagePerMinute { get; set; }
        public string Lane { get; set; } = null!;
        public string ChampionName { get; set; } = null!;
        public DateTime GameEndTimeStamp { get; set; }
        public DateTime GameStartTimeStamp { get; set; }
        public int Summoner1Spell { get; set; }
        public int Summoner2Spell { get; set; }
        public int Item0 { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }
    }
}
