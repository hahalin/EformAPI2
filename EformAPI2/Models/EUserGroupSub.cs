namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EUserGroupSub")]
    public partial class EUserGroupSub
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uflag { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string dep_uid { get; set; }
    }
}
