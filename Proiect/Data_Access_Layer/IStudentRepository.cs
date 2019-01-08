﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPT.Models;

namespace UPT.Data_Access_Layer
{

        public interface IStudentRepository : IDisposable
        {
            IEnumerable<Student> GetStudents();
            Student GetStudentByID(int studentId);
            void InsertStudent(Student student);
            void DeleteStudent(int studentID);
            void UpdateStudent(Student student);
            void Save();
        }

}