using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UPT.Models
{
    [Table("studenti")]
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataInscrierii { get; set; }

        [Display(Name = "Nume intreg")]
        public string NumeIntreg
        {
            get { return Nume + " " + Prenume; }
        }

        public virtual ICollection<Inscriere> Inscrieri { get; set; }
    }
}