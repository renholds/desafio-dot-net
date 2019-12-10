using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TMDB.Application.Entity;
using TMDB.UI.Web.Models;

namespace TMDB.UI.Web.Mappers
{
    public class AutoMapperConfig
    {
        public MapperConfiguration Configure() { 
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<FilmeModel, Filme>();
                cfg.CreateMap<FilmeModelLista, FilmeLista>();
                cfg.AddProfile<FilmeMappingProfile>();
            });
            return config;
        }
        //public MapperConfiguration Configure()
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<Filme, FilmeModel>();
        //    });
        //    return config;
        //}
    }

    public class FilmeMappingProfile : Profile
    {
        public FilmeMappingProfile()
        {
            CreateMap<Filme, FilmeModel>().ReverseMap();
            CreateMap<FilmeLista, FilmeModelLista>().ReverseMap();
        }
    }

    //public class FilmeMappingProfile : Profile
    //{
    //    public FilmeMappingProfile()
    //    {
    //        CreateMap<Filme, FilmeModel>().ReverseMap();
    //    }
    //}
}
