using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace ITRACK.Costing
{
    public class WorkOrderRatio : FullAuditedEntity<Guid>,IMustHaveTenant
    {
        public int TenantId { get; set; }

        [ForeignKey("WorkOrderId")]
        public virtual WorkOrder WorkOrder { get; set; }
        public virtual int WorkOrderId { get; set; }

        public virtual string Color { get; set; }

        public virtual string Size { get; set; }

        public virtual string Length { get; set; }

        public virtual string Quantity { get; set; }

        
    }
}
