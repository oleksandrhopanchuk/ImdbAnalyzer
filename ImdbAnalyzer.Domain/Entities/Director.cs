using System.Collections.Generic;

namespace ImdbAnalyzer.Domain.Entities
{
    public class Director
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}