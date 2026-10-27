namespace ImdbAnalyzer.Domain.Entities
{
    public class Movie
    {
        public int Rank { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Actors { get; set; }
        public string DirectorName { get; set; }
        public Director Director { get; set; }
        public int Year { get; set; }
        public int RuntimeMinutes { get; set; }
        public double Rating { get; set; }
        public int Votes { get; set; }
        public double? RevenueMillions { get; set; }
        public double? Metascore { get; set; }
    }
}