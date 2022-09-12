namespace project_website.Models
{
    public class Match
    {
        public string MatchId { get; set; } = null!;
        public DateTime MatchEndTimestamp { get; set; }
        public List<Participant> Participants { get; set; } = null!;
    }
}
