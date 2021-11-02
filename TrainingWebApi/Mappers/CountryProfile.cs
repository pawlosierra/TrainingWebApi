using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingWebApi.Domain.Models;
using TrainingWebApi.Models;

namespace TrainingWebApi.Mappers
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<CountryResponse, Country>();
            CreateMap<Country, CountryResponse>();

            CreateMap<VisaRequirement, VisaRequirementResponse>();
            CreateMap<VisaRequirementResponse, VisaRequirement>();

            CreateMap<StudentResponse, Student>();
            CreateMap<Student, StudentResponse>();
        }
      
    }
}
