using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingWebApi.Domain.Models;
using TrainingWebApi.Domain.Repositories;
using TrainingWebApi.Infrastructure.Data;
using TrainingWebApi.Infrastructure.Models;

namespace TrainingWebApi.Infrastructure.Repositories
{
    public class VisaRequirementRepository : ICountryRepository
    {
        //private readonly TrainingCenterContext _trainingCenterContext;
        private readonly StudentsDbContex _studentsDbContex;
        private readonly IMapper _mapper;

        public VisaRequirementRepository(StudentsDbContex studentsDbContex, IMapper mapper)
        {
            _studentsDbContex = studentsDbContex;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            //var countries = _trainingCenterContext.Countries.ToList<Countries>();
            //var students = _trainingCenterContext.visaRequirementModel.ToList();
            var students = _studentsDbContex.Students.ToList();
            //var countries = _trainingCenterContext

            var resp = _mapper.Map<IEnumerable<Student>>(students);
            return resp;
        }
    }
}
