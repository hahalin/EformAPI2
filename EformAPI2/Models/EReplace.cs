namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EReplace")]
    public partial class EReplace
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string usr_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string replace_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime start_time { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime end_time { get; set; }

        [StringLength(255)]
        public string usr_reason { get; set; }

        public DateTime? stop_time { get; set; }

        [StringLength(40)]
        public string stop_user { get; set; }
    }
}
