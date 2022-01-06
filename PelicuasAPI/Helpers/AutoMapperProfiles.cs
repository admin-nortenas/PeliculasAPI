﻿using AutoMapper;
using PelicuasAPI.DTOs;
using PelicuasAPI.Entidades;

namespace PelicuasAPI.Helpers
{
    public class AutoMapperProfiles: Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCreacionDTO, Genero>();

            CreateMap<Actor, ActorDTO>().ReverseMap();
            CreateMap<ActorCreacionDTO, Actor>();

        }   

    }
}
