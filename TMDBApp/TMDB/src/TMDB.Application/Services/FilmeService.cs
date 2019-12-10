using System;
using System.Collections.Generic;
using System.Text;
using TMDB.Application.Services;
using TMDB.Application.Entity;
using Newtonsoft.Json;

namespace TMDB.Application.Services
{
    public class FilmeService
    {
        private ApiService apiServ;
        public FilmeService(ApiService apiService)
        {
            this.apiServ = apiService;
        }

        public object Details(int id)
        {
            Filme filme = JsonConvert.DeserializeObject<Filme>(apiServ.GetDetails(id));
            return filme;
        }

        public object LoadMovies()
        {
            FilmeLista filmes = JsonConvert.DeserializeObject<FilmeLista>(apiServ.GetPopularMovies());
            return filmes;
        }
    }
}
