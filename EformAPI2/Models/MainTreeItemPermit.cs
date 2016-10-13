namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainTreeItemPermit")]
    public partial class MainTreeItemPermit
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
        [StringLength(12)]
        public string group_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int child_id { get; set; }

        public short? child_flag { get; set; }
    }
}
