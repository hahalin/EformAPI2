namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EDep")]
    public partial class EDep
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string dep_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public string dep_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string dep_manager { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string dep_pid { get; set; }

        [StringLength(255)]
        public string dep_remark { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dep_flag { get; set; }
    }
}
