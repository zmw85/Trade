namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Currency
    {
        public Currency()
        {
            Countries = new HashSet<Country>();
        }

        public int CurrencyId { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyCode { get; set; }

        [Required]
        [StringLength(50)]
        public string CurrencyName { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}
