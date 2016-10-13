namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainTreeDep")]
    public partial class MainTreeDep
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string dep_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string dep_name { get; set; }

        [StringLength(20)]
        public string dep_manager { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string dep_pid { get; set; }

        [StringLength(255)]
        public string dep_remark { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dep_flag { get; set; }
    }
}
