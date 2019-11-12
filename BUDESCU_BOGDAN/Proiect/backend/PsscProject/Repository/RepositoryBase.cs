﻿using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PsscProject.Repository
{
   public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }
 
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
 
        public IEnumerable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>();
        }
 
        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression);
        }
        public T FindOne(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).FirstOrDefault();
        }
        public T FindById(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).FirstOrDefault();
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }
 
        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }
 
        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }
 
        public void Save()
        {
            this.RepositoryContext.SaveChanges();
        }
    }
}
