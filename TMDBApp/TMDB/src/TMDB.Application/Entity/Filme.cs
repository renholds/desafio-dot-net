using System;
using System.Collections.Generic;

namespace TMDB.Application.Entity
{ 
    public class Filme
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Boolean Adult { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public string Popularity { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public string Status { get; set; }
        public double Vote_count { get; set; }
        public string Vote_average { get; set; }
    }

    public class FilmeLista
    {
        public int Page { get; set; }
        public List<Filme> results { get; set; }
        public int Total_results { get; set; }
        public int Total_pages { get; set; }
    }
}
