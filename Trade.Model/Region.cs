namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Region
    {
        public int RegionId { get; set; }

        [Required]
        [StringLength(50)]
        public string RegionName { get; set; }
    }
}
