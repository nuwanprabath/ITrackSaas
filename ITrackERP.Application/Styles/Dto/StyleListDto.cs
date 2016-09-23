using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ITRACK.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITrackERP.Styles.Dto
{

    [AutoMapFrom(typeof(Style))]
    public class StyleListDto : FullAuditedEntityDto<Guid>
    {
        public string StyleNo { get; set; }

        public string OrderType { get; set; }

        public  string ArticleNo { get; protected set; }

        public  string Season { get; protected set; }

        public  string BocNo { get; set; }

        public  string ItemType { get; set; }

        public  string Remark { get; protected set; }



    }

}
