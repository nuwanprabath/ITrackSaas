using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ITrackERP.Styles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITrackERP.Styles
{
   public interface IStyleAppService : IApplicationService
    {
        ListResultOutput<StyleList> GetStyles();
    }
}
