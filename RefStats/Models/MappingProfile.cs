using AutoMapper;
using RefStats.Models.VeiwModels;
using RefStats.VeiwModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefStats.Models
{
    /// <summary>
    /// Class that is retrieved by automapper.
    /// Automapper searchs for a Profile class in the Models folder by convention.
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domarlista, RefDetailsViewModel>();
            CreateMap<Domarlista, RefAdditionViewModel>();
            CreateMap<Domarlista, MatchViewModel>();
            CreateMap<Domarlista, StatsViewModel>();
            CreateMap<Domarlista, DomarlistaViewModel>();
            CreateMap<Domarlista, InterestViewModel>();
        }

    }   
}
