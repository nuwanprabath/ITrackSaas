using Abp.AutoMapper;
using ITRACK.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITrackERP.Styles.Dto
{
  public  class StyleList
    {

        [AutoMapFrom(typeof(Style))]
        public string StyleNo { get; set; }

        public string Remark { get; set; }

    }
}
