using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPT.Models;

namespace UPT.ViewModels
{
    public class ProfesorIndexData
    {
        public IEnumerable<Profesor> Profesori { get; set; }
        public IEnumerable<Curs> Cursuri { get; set; }
        public IEnumerable<Inscriere> Inscriere { get; set; }
    }
}