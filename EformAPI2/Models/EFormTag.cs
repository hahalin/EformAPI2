namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFormTag")]
    public partial class EFormTag
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
        public string ctl_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string ctl_index { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(60)]
        public string ctl_type { get; set; }

        [StringLength(4)]
        public string ctl_temp { get; set; }

        [StringLength(255)]
        public string ctl_remark { get; set; }

        public int? size { get; set; }

        public bool? show { get; set; }

        public int? row { get; set; }

        public int? ctl_seq { get; set; }

        [StringLength(200)]
        public string exprop { get; set; }

        [StringLength(20)]
        public string ValidMethod { get; set; }

        [StringLength(100)]
        public string ValidMsg { get; set; }
    }
}
