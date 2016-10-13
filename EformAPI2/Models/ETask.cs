namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ETask")]
    public partial class ETask
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int task_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string task_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string task_user { get; set; }

        public int? op_logic { get; set; }

        public int? op_type { get; set; }

        public int? op_value { get; set; }

        [StringLength(32)]
        public string task_owner { get; set; }

        public DateTime? task_date { get; set; }
    }
}
