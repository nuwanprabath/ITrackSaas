using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.Company
{
   public interface IStyleCreationPolicy : IDomainService
    {
        Task CheckIsStyleExistAsync(Style @style);
    }
}
