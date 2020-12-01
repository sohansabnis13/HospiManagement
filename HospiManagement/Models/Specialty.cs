namespace HospiManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;
    [Table("Specialty")]
    public partial class Specialty
    {
        [Key]
        public int Specialty_id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        //public List<SelectListItem> specialty { get; set; }
    }
}
