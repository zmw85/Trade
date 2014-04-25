namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CodeTableEntry
    {
        public CodeTableEntry()
        {
            ProductAttributes = new HashSet<ProductAttribute>();
        }

        public int CodeTableEntryId { get; set; }

        public int CodeTableId { get; set; }

        [Required]
        [StringLength(100)]
        public string CodeTableEntryName { get; set; }

        public virtual CodeTable CodeTable { get; set; }

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    }
}
