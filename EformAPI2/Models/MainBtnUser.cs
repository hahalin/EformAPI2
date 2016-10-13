namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainBtnUser")]
    public partial class MainBtnUser
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string group_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string usr_id { get; set; }
    }
}
