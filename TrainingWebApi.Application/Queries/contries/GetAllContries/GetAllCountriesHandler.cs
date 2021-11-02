using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrainingWebApi.Domain.Models;
using TrainingWebApi.Domain.Repositories;

namespace TrainingWebApi.Application.Queries.contries.GetAllContries
{
    public class GetAllCountriesHandler : IRequestHandler<GetAllCountries, IEnumerable<Student>>
    {
        private readonly ICountryRepository _countryRepository;

        public GetAllCountriesHandler(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<IEnumerable<Student>> Handle(GetAllCountries request, CancellationToken cancellationToken)
        {
            return await _countryRepository.GetAll();
        }
    }
}
