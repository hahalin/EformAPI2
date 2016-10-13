namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECompany")]
    public partial class ECompany
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string co_code { get; set; }

        [StringLength(128)]
        public string co_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string co_name_abbr { get; set; }

        [StringLength(8)]
        public string co_invoice_no { get; set; }

        [StringLength(20)]
        public string boss { get; set; }

        [StringLength(20)]
        public string contact { get; set; }

        [StringLength(20)]
        public string title { get; set; }

        [StringLength(128)]
        public string address { get; set; }

        [StringLength(20)]
        public string tel { get; set; }

        [StringLength(20)]
        public string fax { get; set; }

        [StringLength(14)]
        public string capital { get; set; }

        [StringLength(50)]
        public string remark { get; set; }

        [StringLength(128)]
        public string co_invoice_addr { get; set; }

        [StringLength(3)]
        public string tax_office { get; set; }

        [StringLength(4)]
        public string declare_code { get; set; }

        [StringLength(9)]
        public string tax_code { get; set; }

        public byte? company_type { get; set; }

        [StringLength(12)]
        public string house_code { get; set; }
    }
}
