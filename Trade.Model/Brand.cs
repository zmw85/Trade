namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int BrandId { get; set; }

        [StringLength(50)]
        public string BrandName { get; set; }

        public int CountryId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
