namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainTreeNode")]
    public partial class MainTreeNode
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int co_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int node_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(60)]
        public string node_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int node_pid { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte node_type { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int node_sort { get; set; }

        [StringLength(255)]
        public string node_remark { get; set; }

        [StringLength(60)]
        public string node_exe { get; set; }

        [StringLength(255)]
        public string node_exe_path { get; set; }

        [StringLength(255)]
        public string node_exe_title { get; set; }

        [StringLength(255)]
        public string node_exe_root { get; set; }

        [StringLength(255)]
        public string node_help_path { get; set; }

        [StringLength(255)]
        public string node_help_name { get; set; }

        [StringLength(255)]
        public string node_web_path { get; set; }

        [StringLength(64)]
        public string node_web_file { get; set; }
    }
}
