namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ELoginRecord")]
    public partial class ELoginRecord
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string login_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime login_day { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int login_count { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime day_last { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte now_status { get; set; }

        public int? error_count { get; set; }

        [StringLength(64)]
        public string ip_last { get; set; }
    }
}
