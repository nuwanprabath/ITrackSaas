using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ITrackERP.Styles.Dto;
using Abp.Domain.Repositories;
using ITRACK.Company;
using Abp.AutoMapper;

namespace ITrackERP.Styles
{
    public class StyleAppService : ITrackERPAppServiceBase, IStyleAppService
    {

        private readonly IRepository<Style ,Guid> _styleRepository;


        public StyleAppService(IRepository<Style, Guid> styleRepository)
        {
            _styleRepository = styleRepository;
        }


        public ListResultOutput<StyleList> GetStyles()
        {
            var styles = _styleRepository.GetAll().ToList();

            return new ListResultOutput<StyleList>(styles.MapTo<List<StyleList>>());
        }
    }
}
