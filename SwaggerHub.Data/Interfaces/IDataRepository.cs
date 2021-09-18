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
        Task<Organization> GetOrganizationApisAsync(string orgName);
    }
}
