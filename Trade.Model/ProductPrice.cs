namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductPrice
    {
        public int ProductPriceId { get; set; }

        public int ProductId { get; set; }

        public int PriceId { get; set; }

        public virtual Price Price { get; set; }

        public virtual Product Product { get; set; }
    }
}
