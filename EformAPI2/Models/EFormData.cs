namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFormData")]
    public partial class EFormData
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
        [StringLength(255)]
        public string ctl_id { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string ctl_index { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "text")]
        public string ctl_value { get; set; }
    }
}
