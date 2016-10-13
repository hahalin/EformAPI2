namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ESystemMsg")]
    public partial class ESystemMsg
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int send_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string send_user { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime send_time { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime start_time { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime end_time { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte msg_type { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string msg_title { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "text")]
        public string msg_body { get; set; }

        public byte? msg_level { get; set; }

        [Column(TypeName = "text")]
        public string msg_user { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte msg_to { get; set; }
    }
}
