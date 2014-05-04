namespace Trade.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdminUser
    {
        public int AdminUserId { get; set; }

        public short AdminUserTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public byte Status { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public virtual AdminUserType AdminUserType { get; set; }
    }
}
