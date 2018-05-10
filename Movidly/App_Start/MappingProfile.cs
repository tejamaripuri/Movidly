using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Movidly.Dtos;
using Movidly.Models;

namespace Movidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Customer AutoMapper
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            // Movie AutoMapper
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}