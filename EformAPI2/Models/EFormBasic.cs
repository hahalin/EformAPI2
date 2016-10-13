namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFormBasic")]
    public partial class EFormBasic
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
        [StringLength(255)]
        public string form_name { get; set; }

        [StringLength(255)]
        public string apply_path { get; set; }

        [StringLength(40)]
        public string apply_file { get; set; }

        [StringLength(255)]
        public string check_path { get; set; }

        [StringLength(40)]
        public string check_file { get; set; }

        [StringLength(255)]
        public string notify_path { get; set; }

        [StringLength(40)]
        public string notify_file { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string programmer { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string form_version { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime register_time { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? stop_time { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int status { get; set; }

        [StringLength(255)]
        public string remark { get; set; }

        public int? flow_id { get; set; }

        public int? form_width { get; set; }

        public int? form_height { get; set; }

        public byte? send_type { get; set; }

        public byte? send_to { get; set; }

        public double? send_interval { get; set; }

        public int? form_level { get; set; }

        [StringLength(40)]
        public string help_file { get; set; }

        [StringLength(40)]
        public string print_file { get; set; }

        [StringLength(40)]
        public string read_file { get; set; }

        public byte? stop_apply_flag { get; set; }

        public byte? user_flow_flag { get; set; }

        public byte? add_flow_flag { get; set; }

        public byte? apply_cc_flag { get; set; }

        public byte? apply_file_flag { get; set; }

        public byte? check_file_flag { get; set; }

        public byte? check_all_flag { get; set; }
    }
}
