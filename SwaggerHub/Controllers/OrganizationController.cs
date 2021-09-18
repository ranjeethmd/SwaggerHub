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
    [Route("[controller]")]
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
        public Organization Get(string name)
        {            
            return new Organization();
        }
    }
}
