using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UPT.Models
{
    [Table("profesori")]
    public class Profesor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nume")]
        public string Nume { get; set; }

        [Required]
        [Column("Prenume")]
        [Display(Name = "Prenume")]
        public string Prenume { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Angajarii")]
        public DateTime DataAngajarii { get; set; }

        [Display(Name = "Nume intreg")]
        public string NumeIntreg
        {
            get { return Nume + " " + Prenume; }
        }

        public virtual ICollection<Curs> Cursuri { get; set; }
        public virtual Cabinet Cabinet { get; set; }
    }
}