using SwaggerHub.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerHub.Data.Interfaces
{
    public interface IDataRepository
    {
        Task<OrganizationConfig> GetOriganizationConfigAsync(string orgName);
        Task<Organization> GetOrganizationApisAsync(string orgName);
    }
}
