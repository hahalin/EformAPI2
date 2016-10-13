namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ELoginTotal")]
    public partial class ELoginTotal
    {
        [Key]
        [StringLength(20)]
        public string co_code { get; set; }

        public int? login_total { get; set; }

        public DateTime? system_start { get; set; }
    }
}
