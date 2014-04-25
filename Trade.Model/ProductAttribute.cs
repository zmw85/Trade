namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductAttribute
    {
        [Key]
        public int ProductAttributelId { get; set; }

        public int ProductId { get; set; }

        public int? ProductVariantId { get; set; }

        public int CodeTableId { get; set; }

        public int CodeTableEntryId { get; set; }

        public virtual CodeTableEntry CodeTableEntry { get; set; }

        public virtual CodeTable CodeTable { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductVariant ProductVariant { get; set; }
    }
}
