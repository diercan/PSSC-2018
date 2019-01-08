using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UPT.Models
{
    [Table("inscriere")]
    public class Inscriere
    {
        [Key]
        public int IDInscriere { get; set; }
        public int IDCurs { get; set; }
        public int IDStudent { get; set; }
        [DisplayFormat(NullDisplayText = "Fara nota")]
        public int Nota { get; set; }

        public virtual Curs Curs { get; set; }
        public virtual Student Student { get; set; }
    }
}