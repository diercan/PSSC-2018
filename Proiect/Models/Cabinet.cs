using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UPT.Models
{
    [Table("cabinete")]
    public class Cabinet
    {
        [Key]
        [ForeignKey("Profesor")]
        public int IDProfesor { get; set; }
        [Display(Name = "Cabinet")]
        public string LocatieCabinet { get; set; }

        public virtual Profesor Profesor { get; set; }
    }
}