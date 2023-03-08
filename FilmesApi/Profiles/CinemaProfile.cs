﻿using AutoMapper;
using FilmesApi.Data.Dtos.Cinema;
using FilmesApi.Data.Dtos.Filme;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(cinemaDto => cinemaDto.Endereco, opt => opt.MapFrom(cinema => cinema.Endereco)); 
            CreateMap<UpdateCinemaDto, Cinema>();
           
            
        }
    }
}
