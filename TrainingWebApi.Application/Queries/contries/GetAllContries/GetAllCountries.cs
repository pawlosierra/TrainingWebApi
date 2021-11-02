using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingWebApi.Domain.Models;

namespace TrainingWebApi.Application.Queries.contries.GetAllContries
{
    public class GetAllCountries : IRequest<IEnumerable<Student>>
    {

    }
}
