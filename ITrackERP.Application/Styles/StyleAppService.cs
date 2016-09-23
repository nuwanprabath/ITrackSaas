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
using Abp.Linq.Extensions;
using Abp.UI;



namespace ITrackERP.Styles
{
    public class StyleAppService : ITrackERPAppServiceBase, IStyleAppService
    {

        private readonly IRepository<Style ,Guid> _styleRepository;


        public StyleAppService(IRepository<Style, Guid> styleRepository)
        {
            _styleRepository = styleRepository;
        }


        public ListResultOutput<StyleListDto> GetStyles()
        {
            var styles = _styleRepository.GetAll().ToList();

            return new ListResultOutput<StyleListDto>(styles.MapTo<List<StyleListDto>>());
        }

        public StyleDetailOutput GetDetail(EntityRequestInput<Guid> input)
        {
            var @style =  _styleRepository
                .GetAll()
               
                .Where(e => e.Id == input.Id)
                
                .ToList().FirstOrDefault();

            if (@style == null)
            {
                throw new UserFriendlyException("Could not found the event, maybe it's deleted.");
            }
            return  @style.MapTo<StyleDetailOutput>();

        }



    }
}
