namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public Product()
        {
            Prices = new HashSet<Price>();
            ProductAttributes = new HashSet<ProductAttribute>();
            ProductPrices = new HashSet<ProductPrice>();
            ProductVariants = new HashSet<ProductVariant>();
        }

        public int ProductId { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        public int BrandId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(4000)]
        public string ProductDescriptionText { get; set; }

        public string ProductDescriptionHTML { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual ICollection<Price> Prices { get; set; }

        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }

        public virtual ICollection<ProductPrice> ProductPrices { get; set; }

        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
