using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UPT.ViewModels
{
    public class GrupDataInscriere
    {
        [DataType(DataType.Date)]
        public DateTime? DataInscrierii { get; set; }

        public int NrStudenti { get; set; }
    }
}