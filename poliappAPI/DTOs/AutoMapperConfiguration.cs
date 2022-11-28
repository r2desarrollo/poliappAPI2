using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using poliappAPI.DTOs;
using Microsoft.Extensions.DependencyInjection;

using poliappAPI.Models;

namespace poliappAPI
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Usuario, UsuarioDTO>()
                   .ReverseMap();


                cfg.CreateMap<Pesaje, PesajeDTO>()
                   .ReverseMap();

            });
        }
    }
}
