namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EUserGroup")]
    public partial class EUserGroup
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string ugroup_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string ugroup_name { get; set; }

        [StringLength(255)]
        public string remark { get; set; }
    }
}
