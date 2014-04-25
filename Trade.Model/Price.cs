namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Price
    {
        public Price()
        {
            ProductPrices = new HashSet<ProductPrice>();
        }

        public int PriceId { get; set; }

        public int ProductId { get; set; }

        public int CurrencyId { get; set; }

        [Column("Price", TypeName = "money")]
        public decimal Price1 { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
