using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_System
{
    public class Course : ICourse
    {
        public string CourseName { get; set; }
        public CourseType Type { get; set; }
        public string CourseDescription { get; set; }

        //Methods for returning the courses name, type and description.
        public string GetCourseName()
        {
            return CourseName;
        }

        public CourseType GetCourseType()
        {
            return Type;
        }

        public String GetCourseDescription()
        {
            return CourseDescription;
        }

         //Constructor for initializing courses.
        public Course(string courseName, CourseType type, string courseDescription)
        {
            CourseName = courseName;
            Type = type;
            CourseDescription = courseDescription;
        }

        public static List<Course> GetAvailableCourses(Student student)
        {
            List<Course> allCourses = GetAllCourses();

            // Filter out courses the student is already enrolled in

            List<Course> availableCourses = allCourses.Except(student.StudentsCourses).ToList();

            return availableCourses;
        }

        private static List<Course> allCourses;

        public static List<Course> GetAllCourses()
        {
            // the If/Else making sure it doesn't duplicate courses when GetAllCourses is called.
            if (allCourses == null)
            {
               
                allCourses = new List<Course>
            {
                // Add course objects to the list
                new Course("Geometry", CourseType.Mathematics, "Explore the fundamental concepts of shapes, angles, and spatial relationships in our Geometry course."),
                new Course("English Literature", CourseType.Literature, "Gain insight into classic and contemporary texts, examining themes, characters, and literary techniques of classic English literature."),
                new Course("Biology", CourseType.Science, "Gain a foundational understanding of biological concepts and their real-world applications."),
                new Course("Art History", CourseType.History, "Analyze iconic works and explore the cultural contexts that shaped them, enriching your understanding of art's profound impact on society.")
            };

            }

          
            return allCourses;
        }
    }
}

    
   




