namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Country
    {
        public int CountryId { get; set; }

        [Required]
        [StringLength(2)]
        public string CountryISOCode { get; set; }

        [Required]
        [StringLength(50)]
        public string CountryName { get; set; }

        public int RegionId { get; set; }

        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
