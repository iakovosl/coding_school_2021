using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Uni {

    }

    public class Person {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetName() {
        }
        public void SetName(string name) {
        }
    }

    public class Professor : Person {
        public string Rank { get; set; }
        public int RegistrationNumber { get; set; }

        public Course Course { get; set; }

        public void Teach(Course course, DateTime datetime) {
        }

        public void SetGrade (Guid studentID, Guid courseId, Grade grade) {

        }
 
    }


    public class Student : Person {
        public int RegistrationNumber { get; set; }
        public Course courses { get; set; }
        public void Attend (Course course, DateTime dateTime) {

        }
        public void WriteExam(Course course, DateTime dateTime) {

        }
   
    }

    public class Course {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }

    }

    public class Grade {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grades { get; set; }

    }

    public class Institute {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }
        public void GetName() { 
        }
        public void SetName (string name) {
}
    }

    public class University: Institute {
        public Student Students { get; set; }
        public Course Courses { get; set; }
        public Grade Grades { get; set; }
        public Schedule ScheduleCourse {get; set;}

        public void GetStudents() {

        }
        public void GetCourses() {

        }
        public void GetGrades() {

        }
        public void SetSchedule(Guid CourseId, Guid ProffesorID, DateTime dateTime) {

        }

    }

    public class Schedule: Professor {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }
    }
}
