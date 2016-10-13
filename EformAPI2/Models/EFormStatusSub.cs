namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFormStatusSub")]
    public partial class EFormStatusSub
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int form_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int seq_no { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item_no { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item_row { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item_col { get; set; }

        [StringLength(1000)]
        public string logic_data { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte active_flag { get; set; }

        [StringLength(40)]
        public string check_id { get; set; }

        public byte? check_status { get; set; }

        [Column(TypeName = "text")]
        public string check_remark { get; set; }

        [Key]
        [Column(Order = 7)]
        public byte send_flag { get; set; }

        public DateTime? open_time { get; set; }

        public DateTime? check_time { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int auto_flag { get; set; }

        public DateTime? receive_time { get; set; }

        [StringLength(40)]
        public string default_id { get; set; }

        public byte? item_status { get; set; }

        [StringLength(6800)]
        public string item_remark { get; set; }
    }
}
