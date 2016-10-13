namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EAdvanceFunction")]
    public partial class EAdvanceFunction
    {
        [Key]
        [StringLength(20)]
        public string co_code { get; set; }

        [StringLength(50)]
        public string version_no { get; set; }
    }
}
