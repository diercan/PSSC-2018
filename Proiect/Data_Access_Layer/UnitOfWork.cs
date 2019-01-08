using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPT.Models;

namespace UPT.Data_Access_Layer
{
    public class UnitOfWork : IDisposable
    {
        private ContextUniversitate context = new ContextUniversitate();
        private GenericRepository<Departament> departamentRepository;
        private GenericRepository<Curs> cursRepository;
        private GenericRepository<Profesor> profesorRepository;

        public GenericRepository<Departament> DepartamentRepository
        {
            get
            {
                return this.departamentRepository ?? new GenericRepository<Departament>(context);
            }
        }

        public GenericRepository<Curs> CursRepository
        {
            get
            {
                return this.cursRepository ?? new GenericRepository<Curs>(context);
            }
        }

        public GenericRepository<Profesor> ProfesorRepository
        {
            get
            {
                return this.profesorRepository ?? new GenericRepository<Profesor>(context);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}