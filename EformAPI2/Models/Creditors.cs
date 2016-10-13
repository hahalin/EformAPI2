namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Creditors
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string nm { get; set; }

        [Required]
        [StringLength(20)]
        public string cnm { get; set; }
    }
}
