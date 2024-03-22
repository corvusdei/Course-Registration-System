

using Course_Registration_System;
using System;

class Program
{
    static void Main(string[] args)
    {
        

        Student student = new Student(12345,"Jane Doe");

        while (true) //Looping main menu, so users return here instead of exiting the program.
        {
            Console.WriteLine("You're Using The Course Registration System");
            Console.WriteLine("1 - Enroll in a course");
            Console.WriteLine("2 - Drop a course");
            Console.WriteLine("3 - View your enrollment status");
            Console.WriteLine("4 - Exit");

            Console.Write(":");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EnrollInCourse(student);
                    break;
                case "2":
                   DropACourse(student);
                    break;
                case "3":
                    student.ViewEnrollmentStatus();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 - 4");
                    break;
            }
        }
    }

    static void EnrollInCourse(Student student)

    {
        while (true) // Enrollment Loop
        {
            // display available courses only and numbering them

            List<Course> availableCourses = Course.GetAvailableCourses(student);

            Console.WriteLine("Available Courses:");
            Console.WriteLine("0. Exit Enrollment Menu");
            for (int i = 0; i < availableCourses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableCourses[i].CourseName} - {availableCourses[i].CourseDescription}");
            }

            Console.Write("Enter the course you'd like to enroll in: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= availableCourses.Count)
            {
                // Enroll the student in the selected course

                Course selectedCourse = availableCourses[choice - 1];
                student.EnrollCourse(selectedCourse);
                Console.WriteLine($"Enrolled in {selectedCourse.CourseName}.");
                //Update available courses after enrollment
                availableCourses = Course.GetAvailableCourses(student);
                break;
            }
            else if (choice == 0)
            {
                Console.WriteLine("Enrollment canceled.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid number.");
            }

        }

    }

    static void DropACourse(Student student)
    {
        while (true) // Drop Course Loop
        {
            Console.WriteLine("Your enrolled courses:");
            student.ViewEnrollmentStatus();

            List<Course> enrolledCourses = student.StudentsCourses;

            Console.WriteLine("Enter the course you'd like to drop:");
            Console.WriteLine("0. Cancel");

            for (int i = 0; i < enrolledCourses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {enrolledCourses[i].CourseName} - {enrolledCourses[i].CourseDescription}");
            }

            Console.Write("Enter the course number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= enrolledCourses.Count)
            {
                // Drop the selected course
                Course courseToRemove = enrolledCourses[choice - 1];
                student.DropCourse(courseToRemove);
                Console.WriteLine($"Successfully dropped {courseToRemove.CourseName}.");
                break;
            }
            else if (choice == 0)
            {
                Console.WriteLine("Course dropping canceled.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid number.");
            }
        }

    }


  }
