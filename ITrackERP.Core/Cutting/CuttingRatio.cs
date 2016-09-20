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

namespace ITRACK.Cutting
{
    public class CuttingRatio : FullAuditedEntity<Guid>, IMustHaveTenant
    {
        public const int MaxTitleLength = 128;
        public const int MaxDescriptionLength = 2048;


        public int TenantId { get; set; }

        [Key]
        public virtual int RatioId { get; set; }

        public virtual string Color { get; set; }

        public virtual int Length { get; set; }

        public virtual int MarkerLength { get; set; }

        public virtual int MarkerWidth { get; set; }

        public virtual int LayerLength { get; set; }

        public virtual string FabricType { get; set; }

        public virtual string Remark { get; set; }

        [ForeignKey("StyleId")]
        public virtual Style Style { get; set; }

        public virtual int StyleId { get; set; }





    }

}
