using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwaggerHub.Data;
using SwaggerHub.Data.DTO;
using SwaggerHub.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerHub.Controllers
{
    [ApiController]
    [Route("apis/[controller]")]
    public class OrganizationController : ControllerBase
    {        
        private readonly ILogger<OrganizationController> _logger;
        private IDataRepository _repository;

        public OrganizationController(ILogger<OrganizationController> logger, IDataRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("{name}")]
        public async Task<Organization> Get(string name)
        {            
            return await _repository.GetOrganizationApisAsync(name);
        }

        [HttpGet()]
        public async Task<OrganizationConfig> Get()
        {
            return await _repository.GetOriganizationConfigAsync("dummy");
        }
    }
}
