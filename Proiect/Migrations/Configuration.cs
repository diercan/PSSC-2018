namespace UPT.Migrations
{
    using UPT.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UPT.Data_Access_Layer;

    internal sealed class Configuration : DbMigrationsConfiguration<UPT.Data_Access_Layer.ContextUniversitate>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UPT.Data_Access_Layer.ContextUniversitate context)
        {
            var studenti = new List<Student>
            {
                new Student { Nume = "Popescu",   Prenume = "Ion",
                    DataInscrierii = DateTime.Parse("09-09-2015") },
                new Student { Nume = "Mihai",   Prenume = "Adrei",
                    DataInscrierii = DateTime.Parse("09-09-2016") },
                new Student { Nume = "Stefan",   Prenume = "Elena",
                    DataInscrierii = DateTime.Parse("09-09-2014") },
                new Student { Nume = "Dumitru",   Prenume = "Alexandru",
                    DataInscrierii = DateTime.Parse("09-09-2016") }
            };

            studenti.ForEach(s => context.Studenti.AddOrUpdate(p => p.Nume, s));
            context.SaveChanges();

            var profesori = new List<Profesor>
            {
                new Profesor { Nume = "Anton",     Prenume = "Ioan",
                    DataAngajarii = DateTime.Parse("03-11-2005") },
                new Profesor { Nume = "Popa",     Prenume = "Bogdan",
                    DataAngajarii = DateTime.Parse("03-11-2003") },
                new Profesor { Nume = "Costea",     Prenume = "Cristian",
                    DataAngajarii = DateTime.Parse("03-11-2000") },
                new Profesor { Nume = "Adamescu",     Prenume = "Andreea",
                    DataAngajarii = DateTime.Parse("03-11-2013") },
                new Profesor { Nume = "Ilie",     Prenume = "Ioana",
                    DataAngajarii = DateTime.Parse("03-11-2010") },
                new Profesor { Nume = "Dan",     Prenume = "Adrian",
                    DataAngajarii = DateTime.Parse("03-11-2008") }
            };
            profesori.ForEach(s => context.Profesori.AddOrUpdate(p => p.Nume, s));
            context.SaveChanges();

            var departamente = new List<Departament>
            {
                new Departament { Nume = "IS",     Buget = 350000,
                    DataInceperii = DateTime.Parse("09-01-2012"),
                    IDProfesor  = profesori.Single( i => i.Nume == "Popa").ID },
                new Departament { Nume = "CTI",     Buget = 350000,
                    DataInceperii = DateTime.Parse("09-01-2012"),
                    IDProfesor  = profesori.Single( i => i.Nume == "Anton").ID }
            };
            departamente.ForEach(s => context.Departamente.AddOrUpdate(p => p.Nume, s));
            context.SaveChanges();

            var cursuri = new List<Curs>
            {
                new Curs {IDCurs = 1, Titlu = "Algebra",      Credite = 4,
                  IDDepartament = departamente.Single( s => s.Nume == "IS").IDDepartament,
                  Profesori = new List<Profesor>()
                },
                new Curs {IDCurs = 2, Titlu = "AM",      Credite = 4,
                  IDDepartament = departamente.Single( s => s.Nume == "IS").IDDepartament,
                  Profesori = new List<Profesor>()
                },
                new Curs {IDCurs = 3, Titlu = "TS",      Credite = 4,
                  IDDepartament = departamente.Single( s => s.Nume == "CTI").IDDepartament,
                  Profesori = new List<Profesor>()
                },
                new Curs {IDCurs = 4, Titlu = "CD",      Credite = 4,
                  IDDepartament = departamente.Single( s => s.Nume == "CTI").IDDepartament,
                  Profesori = new List<Profesor>()
                },
                new Curs {IDCurs = 5, Titlu = "SBMM",      Credite = 4,
                  IDDepartament = departamente.Single( s => s.Nume == "IS").IDDepartament,
                  Profesori = new List<Profesor>()
                },
                new Curs {IDCurs = 6, Titlu = "LSD",      Credite = 4,
                  IDDepartament = departamente.Single( s => s.Nume == "IS").IDDepartament,
                  Profesori = new List<Profesor>()
                },
                new Curs {IDCurs = 7, Titlu = "SGT",      Credite = 4,
                  IDDepartament = departamente.Single( s => s.Nume == "IS").IDDepartament,
                  Profesori = new List<Profesor>()
                }

            };
            cursuri.ForEach(s => context.Cursuri.AddOrUpdate(p => p.IDCurs, s));
            context.SaveChanges();

            var cabinete = new List<Cabinet>
            {
                new Cabinet {
                    IDProfesor = profesori.Single( i => i.Nume == "Anton").ID,
                    LocatieCabinet = "A307" },
                new Cabinet {
                    IDProfesor = profesori.Single( i => i.Nume == "Popa").ID,
                    LocatieCabinet = "A306" },
                new Cabinet {
                    IDProfesor = profesori.Single( i => i.Nume == "Costea").ID,
                    LocatieCabinet = "A115" },
                new Cabinet {
                    IDProfesor = profesori.Single( i => i.Nume == "Adamescu").ID,
                    LocatieCabinet = "B017" },
                new Cabinet {
                    IDProfesor = profesori.Single( i => i.Nume == "Ilie").ID,
                    LocatieCabinet = "A207" },
                new Cabinet {
                    IDProfesor = profesori.Single( i => i.Nume == "Dan").ID,
                    LocatieCabinet = "B607" }

            };
            cabinete.ForEach(s => context.Cabinete.AddOrUpdate(p => p.IDProfesor, s));
            context.SaveChanges();

            AddOrUpdateProfesor(context, "Algebra", "Popa");
            AddOrUpdateProfesor(context, "AM", "Anton");
            AddOrUpdateProfesor(context, "LSD", "Costea");
            AddOrUpdateProfesor(context, "SBMM", "Adamescu");
            AddOrUpdateProfesor(context, "CD", "Ilie");
            AddOrUpdateProfesor(context, "TS", "Dan");
            AddOrUpdateProfesor(context, "SGT", "Anton");


            context.SaveChanges();

            var inscrieri = new List<Inscriere>
            {
                new Inscriere {
                    IDStudent = studenti.Single(s => s.Nume == "Stefan").ID,
                    IDCurs = cursuri.Single(c => c.Titlu == "Algebra" ).IDCurs,
                    Nota = 8
                },
                new Inscriere {
                    IDStudent = studenti.Single(s => s.Nume == "Popescu").ID,
                    IDCurs = cursuri.Single(c => c.Titlu == "AM" ).IDCurs,
                    Nota = 8
                },
                new Inscriere {
                    IDStudent = studenti.Single(s => s.Nume == "Stefan").ID,
                    IDCurs = cursuri.Single(c => c.Titlu == "LSD" ).IDCurs,
                    Nota = 8
                },
                new Inscriere {
                    IDStudent = studenti.Single(s => s.Nume == "Mihai").ID,
                    IDCurs = cursuri.Single(c => c.Titlu == "CD" ).IDCurs,
                    Nota = 8
                },
                new Inscriere {
                    IDStudent = studenti.Single(s => s.Nume == "Dumitru").ID,
                    IDCurs = cursuri.Single(c => c.Titlu == "TS" ).IDCurs,
                    Nota = 8
                },
                 new Inscriere {
                    IDStudent = studenti.Single(s => s.Nume == "Mihai").ID,
                    IDCurs = cursuri.Single(c => c.Titlu == "SBMM" ).IDCurs,
                    Nota = 8
                },
            };

            foreach (Inscriere e in inscrieri)
            {
                var inscriereInDataBase = context.Inscrieri.Where(
                    s =>
                         s.Student.ID == e.IDStudent &&
                         s.Curs.IDCurs == e.IDCurs).SingleOrDefault();
                if (inscriereInDataBase == null)
                {
                    context.Inscrieri.Add(e);
                }
            }
            context.SaveChanges();
        }

        void AddOrUpdateProfesor(ContextUniversitate context, string titluCurs, string numeProfesor)
        {
            var crs = context.Cursuri.SingleOrDefault(c => c.Titlu == titluCurs);
            var prof = crs.Profesori.SingleOrDefault(i => i.Nume == numeProfesor);
            if (prof == null)
                crs.Profesori.Add(context.Profesori.Single(i => i.Nume == numeProfesor));
        }
    }
}