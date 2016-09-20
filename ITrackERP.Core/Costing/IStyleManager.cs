using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.Company
{
    public interface IStyleManager : IDomainService
    {
        // Get Event B
        Task<Style> GetAsync(Guid id);

        Task CreateAsync(Style @style);

        Task UpdateAsync(Style @style);

        void Cancel(Style @style);


    }
}
