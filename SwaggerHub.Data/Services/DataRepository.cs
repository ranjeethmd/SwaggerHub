using Newtonsoft.Json;
using SwaggerHub.Data.DTO;
using SwaggerHub.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerHub.Data.Services
{
    public class DataRepository : IDataRepository
    {
        public async Task<Organization> GetOrganizationApisAsync(string orgName)
        {
            var json = await File.ReadAllTextAsync(@"C:\Users\ranje\source\repos\SwaggerHub\org.json");
            return JsonConvert.DeserializeObject<Organization>(json);
        }

        public async Task<OrganizationConfig> GetOriganizationConfigAsync(string orgName)
        {
            var json = await File.ReadAllTextAsync(@"C:\Users\ranje\source\repos\SwaggerHub\config.json");
            return JsonConvert.DeserializeObject<OrganizationConfig>(json);
        }
    }
}
