namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainTreeExe")]
    public partial class MainTreeExe
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string node_exe_root { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string node_exe_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string node_exe_path { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string node_exe_title { get; set; }

        [StringLength(255)]
        public string node_exe_source { get; set; }

        [StringLength(12)]
        public string node_exe_version { get; set; }

        public DateTime? node_exe_date { get; set; }

        [StringLength(255)]
        public string node_process_title { get; set; }
    }
}
