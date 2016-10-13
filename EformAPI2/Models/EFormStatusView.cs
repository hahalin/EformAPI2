namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EFormStatusView")]
    public partial class EFormStatusView
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
        [StringLength(40)]
        public string login_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string time_stamp { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string usr_id { get; set; }

        public int? seq_no { get; set; }

        public DateTime? receive_time { get; set; }

        public DateTime? open_time { get; set; }

        public byte? cc_type { get; set; }
    }
}
