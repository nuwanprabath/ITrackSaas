using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using ITRACK.Company;
using ITRACK.Cutting;

namespace ITRACK.Costing
{
    public class WorkOrder : FullAuditedEntity<Guid>,IMustHaveTenant
    {
        public const int MaxTitleLength = 128;
        public const int MaxDescriptionLength = 2048;

    
        public virtual int TenantId { get; set; }

        [Required]
        [Key]
        public virtual int WorkOrderId { get; set; }

        public virtual string PoNo { get; set; }

        [Required]
        public virtual DateTime StartDate { get; set; }

        [Required]
        public virtual DateTime EndTime { get; set; }

        public virtual string Status { get; set; }

        public virtual string Priority { get; set; }

        public virtual string Remark { get; set; }

        

        public virtual ICollection<WorkOrderRatio> WorkOrderRatios { get; set; }



    }
}
