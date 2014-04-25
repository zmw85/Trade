namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductVariant
    {
        public ProductVariant()
        {
            ProductAttributes = new HashSet<ProductAttribute>();
        }

        public int ProductVariantId { get; set; }

        public int ProductId { get; set; }

        [StringLength(100)]
        public string ProductVariantName { get; set; }

        public bool InStock { get; set; }

        [StringLength(20)]
        public string ColourName { get; set; }

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }

        public virtual Product Product { get; set; }
    }
}
