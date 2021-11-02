using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrainingWebApi.Domain.Models;

namespace TrainingWebApi.Domain.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Student>> GetAll();
    }
}
