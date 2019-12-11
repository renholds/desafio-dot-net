using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDB.Application.Services
{
    public class ApiService
    {
        static string apikey = "6f085c8aa3c4dcaba68d37639f750783";
        private string urlNewToken = "https://api.themoviedb.org/3/authentication/token/new?api_key=" + apikey.Trim();
        private string urlNewSession = "https://api.themoviedb.org/3/authentication/session/new?api_key=" + apikey.Trim();
        private string urlGetDetails = "https://api.themoviedb.org/3/movie/{movie_id}?api_key=" + apikey.Trim() + "&language=pt-BR";
        private string urlLoadMovies = "https://api.themoviedb.org/3/movie/popular?api_key=" + apikey.Trim();
        private string urlSearchMovies = "https://api.themoviedb.org/3/search/movie?api_key=" + apikey.Trim() + "&query={search_string}";

        public IRestResponse Authentication()
        {
            var client = new RestClient(urlNewToken);
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response;
        }

        public void NewSession()
        {
            var client = new RestClient(urlNewSession);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            //request.AddParameter("application/json", "{\"request_token\":\"6bc047b88f669d1fb86574f06381005d93d3517a\"}", ParameterType.RequestBody);
            request.AddParameter("application/json", "{\"request_token\":\"" + Authentication() + "\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public string GetDetails(int id)
        {
            string urlDetail = urlGetDetails.Replace("{movie_id}", id.ToString());
            var client = new RestClient(urlDetail);
            //var client = new RestClient("https://api.themoviedb.org/3/movie/3?api_key=6f085c8aa3c4dcaba68d37639f750783&language=pt-BR"); //teste
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string GetPopularMovies()
        {
            var client = new RestClient(urlLoadMovies);
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string SearchMovies(string query)
        {
            string urlSearch= urlSearchMovies.Replace("{search_string}", query);
            var client = new RestClient(urlSearch);
            var request = new RestRequest(Method.GET);
            request.AddParameter("undefined", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
