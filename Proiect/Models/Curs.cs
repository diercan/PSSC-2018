using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UPT.Models
{
    [Table("cursuri")]
    public class Curs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int IDCurs { get; set; }
        public string Titlu { get; set; }
        public int Credite { get; set; }

        public int IDDepartament { get; set; }

        public virtual Departament Departament { get; set; }
        public virtual ICollection<Profesor> Profesori { get; set; }
        public virtual ICollection<Inscriere> Inscriere { get; set; }
    }
}