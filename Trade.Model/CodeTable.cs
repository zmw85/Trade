namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CodeTable
    {
        public CodeTable()
        {
            CodeTableEntries = new HashSet<CodeTableEntry>();
            ProductAttributes = new HashSet<ProductAttribute>();
        }

        public int CodeTableId { get; set; }

        [Required]
        [StringLength(100)]
        public string CodeTableName { get; set; }

        public virtual ICollection<CodeTableEntry> CodeTableEntries { get; set; }

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    }
}
