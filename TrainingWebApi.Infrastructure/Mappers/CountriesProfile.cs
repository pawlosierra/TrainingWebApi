using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingWebApi.Domain.Models;
using TrainingWebApi.Infrastructure.Models;

namespace TrainingWebApi.Infrastructure.Mappers
{
    public class CountriesProfile : Profile
    {
        public CountriesProfile()
        {
            CreateMap<Country, Countries>();
            CreateMap<Countries, Country>();

            CreateMap<VisaRequirement, VisaRequirementModel>();
            CreateMap<VisaRequirementModel, VisaRequirement>();

            CreateMap<Student, StudentModel>();
            CreateMap<StudentModel, Student>();
        }
    }
}
