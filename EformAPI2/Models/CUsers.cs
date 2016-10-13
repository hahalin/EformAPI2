namespace EformAPI2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CUsers
    {
        public int id { get; set; }

        public string userid { get; set; }

        public string pwd { get; set; }
    }
}
