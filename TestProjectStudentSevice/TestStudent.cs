﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentService;
using System.Net.Http.Headers;

namespace TestProjectStudentSevice
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void addStudentNotExits()
        {

            Student s = new Student() { Id = 1,Name="vũ",Age=20 };
            Student s1 = new Student() { Id = 2, Name = "Lộc", Age = 20 };

            StudentService.StudentService studentsv = new StudentService.StudentService();
            studentsv.addStudent(s);
            

            Assert.IsFalse(studentsv.addStudent(s1));
            
        }

        /*[TestClass]
        public void TestScore()
        {
            Student student = new Student();
            int s = student.Score(8);
        }*/

    }
}