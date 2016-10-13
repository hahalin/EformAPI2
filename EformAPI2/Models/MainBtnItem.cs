namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainBtnItem")]
    public partial class MainBtnItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string parent_caption { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int child_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string child_caption { get; set; }
    }
}
