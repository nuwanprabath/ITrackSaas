using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ITRACK.Costing;

namespace ITRACK.Company
{
    public  class Style : FullAuditedEntity<Guid>, IMustHaveTenant
    {
        public const int MaxTitleLength = 128;
        public const int MaxDescriptionLength = 2048;

        
        public virtual int TenantId { get; set; }


        [Key]

        [Required]
        [StringLength(MaxTitleLength)]
        public virtual string StyleNo { get; protected set; }

        public virtual string ArticleNo { get; protected set; }


        public virtual string Season { get; protected set; }

        public virtual string Remark { get; protected set; }

        public virtual string OrderType { get; set; }

        public virtual string Department { get; set; }

        [Required]
        public virtual string BocNo { get; set; }

        public virtual string ItemType { get; set; }

        [Required]
        public virtual string BuyerId { get; set; }

        public virtual string ImagePath { get; set; }

      public virtual ICollection<WorkOrder> WorkOrders { get; set; }





      


    }
}
