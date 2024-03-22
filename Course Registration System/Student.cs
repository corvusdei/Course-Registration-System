using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_System
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public List<Course> StudentsCourses { get; set; }

        // Student Constructor
        public Student(int studentId, string studentName)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentsCourses = new List<Course>();
        }

        // Initialize student courses list

        public Student()
        {
            StudentsCourses = new List<Course>();
        }

        // The following methods are how the student can interact with classes, enrolling, dropping or viewing them.

        public void EnrollCourse(Course selectedCourse)
        {

        StudentsCourses.Add(selectedCourse);

        }

        public void DropCourse(Course course)
        {

          
        }
         public void ViewEnrollmentStatus()
        {
            Console.WriteLine($"Name:{StudentName}");
            Console.WriteLine($"Student ID:{StudentId}");
            Console.WriteLine("Currently Enrolled in:");

            if (StudentsCourses.Count == 0)
            {
                Console.WriteLine("No courses enrolled.");
            }

            else
            {
                foreach (var course in StudentsCourses)
                    Console.WriteLine($"{course.CourseName} - {course.CourseDescription}");
            }

        }
    }
}
