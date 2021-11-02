using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingWebApi.Application.Queries.contries.GetAllContries;

namespace TrainingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CountriesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var countries = await _mediator.Send(new GetAllCountries());
            return Ok(countries);
        }
    }
}
