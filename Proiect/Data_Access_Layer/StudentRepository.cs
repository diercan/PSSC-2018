using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UPT.Models;

namespace UPT.Data_Access_Layer
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private ContextUniversitate context;

        public StudentRepository(ContextUniversitate context)
        {
            this.context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Studenti.ToList();
        }

        public Student GetStudentByID(int id)
        {
            return context.Studenti.Find(id);
        }

        public void InsertStudent(Student student)
        {
            context.Studenti.Add(student);
        }

        public void DeleteStudent(int studentID)
        {
            Student student = context.Studenti.Find(studentID);
            context.Studenti.Remove(student);
        }

        public void UpdateStudent(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
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