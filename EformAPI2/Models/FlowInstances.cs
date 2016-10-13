namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FlowInstances
    {
        public int id { get; set; }

        public DateTime fdate { get; set; }

        public string username { get; set; }

        [StringLength(100)]
        public string title { get; set; }

        [StringLength(200)]
        public string smemo { get; set; }
    }
}
