﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using yado_backend.Models.Dtos;
using yado_backend.Repositories;

namespace yado_backend.Controllers
{
    [ApiController]
    [Route("api/populations")]
    public class PopulationController : ControllerBase
    {
        private readonly IPopulationRepository _populationRepository;

        public PopulationController(IPopulationRepository populationRepository)
        {
            _populationRepository = populationRepository;
        }

        [AllowAnonymous]
        [HttpGet("search")]
        [ResponseCache(Duration = 86400)]
        public async Task<ActionResult<IEnumerable<PopulationDto>>> SearchPopulationsByCityName(string cityName)
        {
            var similarPopulations = await _populationRepository.SearchPopulationsByCityName(cityName);

            var populationDtos = similarPopulations.Select(population => new PopulationDto
            {
                ID = population.ID,
                Name = population.Name
            });

            return Ok(populationDtos);
        }
    }
}