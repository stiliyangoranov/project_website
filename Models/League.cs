﻿namespace project_website.Models
{
    public class League
    {
        public string LeagueId { get; set; } = null!;
        public string QueueType { set; get; } = null!;
        public string Tier { get; set; } = null!;
        public string Rank { get; set; } = null!;
        public string SummonerId { get; set; } = null!;
        public string SummonerName { get; set; } = null!;
        public int LeaguePoints { get; set; }  
        public int Wins { get; set; }
        public int Losses { get; set; }
        public bool Veteran { get; set; }
        public bool Inactive { get; set; }
        public bool FreshBlood { get; set; }
        public bool HotStreak { get; set; }
    }
}
