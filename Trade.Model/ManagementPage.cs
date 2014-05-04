namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ManagementPage
    {
        public ManagementPage()
        {
            AdminUserTypes = new HashSet<AdminUserType>();
        }

        public int ManagementPageId { get; set; }

        [Required]
        [StringLength(200)]
        public string PageTitle { get; set; }

        [StringLength(200)]
        public string PageTitleCN { get; set; }

        [Required]
        [StringLength(200)]
        public string Route { get; set; }

        public byte PageStatus { get; set; }

        public virtual ICollection<AdminUserType> AdminUserTypes { get; set; }
    }
}
