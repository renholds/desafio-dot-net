using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TMDB.UI.Web.Models;
using TMDB.Application.Entity;
using AutoMapper;
using TMDB.Application.Services;
using TMDB.UI.Web.Mappers;


namespace TMDB.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private FilmeService filmeService;
        private AutoMapperConfig autoMap;
        public HomeController(FilmeService filmeService, AutoMapperConfig autoMap)
        {
            this.filmeService = filmeService;
            this.autoMap = autoMap;
        }

        public IActionResult Index(FilmeModelLista FilmeLista)
        {
            if (FilmeLista.results == null){
                return FilmesPopulares();//View();
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Filme(int id)
        {
            var filme = filmeService.Details(id);
            IMapper iMapper = autoMap.Configure().CreateMapper();
            FilmeModel filmeMod = iMapper.Map<FilmeModel>(filme); //Mapper.Map<FilmeModel>(filme);
            return View(filmeMod);
        }

        [HttpGet]
        public IActionResult FilmesPopulares()
        {
            var Listafilmes = filmeService.LoadPopularMovies();
            IMapper iMapper = autoMap.Configure().CreateMapper();
            FilmeModelLista FilmeLista = iMapper.Map<FilmeModelLista>(Listafilmes);
            return View(FilmeLista);
        }

        //[HttpGet]
        [HttpPost("Consulta")]
        [Route("/Home/Consulta")]
        public IActionResult Consulta(string query)
        {
            var Listafilmes = filmeService.Search(query);
            IMapper iMapper = autoMap.Configure().CreateMapper();
            FilmeModelLista FilmeLista = iMapper.Map<FilmeModelLista>(Listafilmes);
            return View("Index", FilmeLista);
        }
    }
}
