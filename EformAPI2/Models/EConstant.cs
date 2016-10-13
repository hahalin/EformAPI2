namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EConstant")]
    public partial class EConstant
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string constant_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string constant_value { get; set; }
    }
}
