namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EUser")]
    public partial class EUser
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
        public string usr_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string usr_email { get; set; }

        [StringLength(20)]
        public string usr_tel { get; set; }

        [StringLength(20)]
        public string usr_subtel { get; set; }

        [StringLength(20)]
        public string usr_celltel { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(32)]
        public string usr_pwd { get; set; }

        [StringLength(40)]
        public string dep_id { get; set; }

        public int? class_id { get; set; }

        [StringLength(40)]
        public string usr_replace { get; set; }

        [Column(TypeName = "text")]
        public string usr_remark { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        public byte? use_flag { get; set; }

        [StringLength(60)]
        public string usr_title { get; set; }

        [StringLength(255)]
        public string usr_reason { get; set; }

        [StringLength(40)]
        public string usr_replace1 { get; set; }

        public byte? nation_id { get; set; }

        [StringLength(20)]
        public string pwd2 { get; set; }
    }
}
