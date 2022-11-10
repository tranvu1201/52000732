using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void addStudentNull_NullReferenceException()
        {

            Student s = new Student() { Id = 1, Name = "huy", Age = 20 };
            StudentService.StudentService studentsv = new StudentService.StudentService();
           

            try { 
                if(studentsv!=null)
                {
                    studentsv.addStudent(s); 
                }    
                
            } catch (NullReferenceException e) 
            {
                throw new Exception();
                    
             };
           

        }

        [TestMethod]
        public void checkscore()
        {
            Student st = new Student();
            double s = st.Score;
            st.Score = 10;
            if(st.Score>0 && st.Score<0)
            {
                throw new Exception();
            }
        }

    }
}