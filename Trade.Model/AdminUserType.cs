namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdminUserType
    {
        public AdminUserType()
        {
            AdminUsers = new HashSet<AdminUser>();
            ManagementPages = new HashSet<ManagementPage>();
        }

        public short AdminUserTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserTypeName { get; set; }

        [StringLength(50)]
        public string UserTypeNameCN { get; set; }

        public virtual ICollection<AdminUser> AdminUsers { get; set; }

        public virtual ICollection<ManagementPage> ManagementPages { get; set; }
    }
}
