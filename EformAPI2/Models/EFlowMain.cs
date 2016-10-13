namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFlowMain")]
    public partial class EFlowMain
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flow_id { get; set; }

        [Required]
        [StringLength(255)]
        public string flow_name { get; set; }

        [StringLength(255)]
        public string flow_share_nmae { get; set; }

        [Required]
        [StringLength(40)]
        public string designer { get; set; }

        public DateTime design_time { get; set; }

        [StringLength(40)]
        public string modifier { get; set; }

        public DateTime? modify_time { get; set; }

        [Required]
        [StringLength(20)]
        public string flow_version { get; set; }

        [Column(TypeName = "text")]
        public string remark { get; set; }
    }
}
