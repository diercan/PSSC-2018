using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UPT.Models
{
    [Table("departamente")]
    public class Departament
    {
        [Key]
        public int IDDepartament { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string Nume { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Buget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime DataInceperii { get; set; }

        public int? IDProfesor { get; set; }

        public virtual Profesor Administrator { get; set; }
        public virtual ICollection<Curs> Cursuri { get; set; }
    }
}