using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPT.Models;

namespace UPT.Data_Access_Layer
{
    public class UniversitateInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContextUniversitate>
    {
        protected override void Seed(ContextUniversitate context)
        {
            var studenti = new List<Models.Student>
            {
            new Student{ID=1, Nume="Popescu",Prenume="Ion",DataInscrierii=DateTime.Parse("2015-09-01")},
            new Student{ID=2, Nume="Mihai",Prenume="Emanuel",DataInscrierii=DateTime.Parse("2016-09-01")},
            new Student{ID=3, Nume="Stefan",Prenume="Alina",DataInscrierii=DateTime.Parse("2014-09-01")},
            new Student{ID=4, Nume="Bota",Prenume="Cristina",DataInscrierii=DateTime.Parse("2015-09-01")},
            new Student{ID=5, Nume="Dumitru",Prenume="Mirela",DataInscrierii=DateTime.Parse("2017-09-01")}
            };

            studenti.ForEach(s => context.Studenti.Add(s));
            context.SaveChanges();
            var cursuri = new List<Curs>
            {
            new Curs{IDCurs=1,Titlu="Programarea Calculatoarelor",Credite=5},
            new Curs{IDCurs=2,Titlu="Algebra",Credite=4},
            new Curs{IDCurs=3,Titlu="Analiza matematica",Credite=4},
            new Curs{IDCurs=4,Titlu="Logica si structuri discrete",Credite=4},
            new Curs{IDCurs=5,Titlu="Fizica",Credite=4},
            new Curs{IDCurs=6,Titlu="Limba straina 1",Credite=3},
            new Curs{IDCurs=7,Titlu="Sport",Credite=2}
            };
            cursuri.ForEach(s => context.Cursuri.Add(s));
            context.SaveChanges();
            var inscrieri = new List<Inscriere>
            {
            new Inscriere{IDStudent=1,IDCurs=1,Nota=8},
            new Inscriere{IDStudent=2,IDCurs=2,Nota=5},
            new Inscriere{IDStudent=2,IDCurs=3,Nota=7},
            new Inscriere{IDStudent=1,IDCurs=4},
            new Inscriere{IDStudent=3,IDCurs=4,Nota=10},
            new Inscriere{IDStudent=4,IDCurs=6,Nota=9},
            new Inscriere{IDStudent=5,IDCurs=7},
            new Inscriere{IDStudent=3,IDCurs=2,Nota=8}
            };
            inscrieri.ForEach(s => context.Inscrieri.Add(s));
            context.SaveChanges();
        }
    }
}