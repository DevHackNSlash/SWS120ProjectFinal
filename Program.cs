/*
 Group:           SWS
 Version:         1.0
 Due Date:        April 10th 2023 
 Assignment:      SWS Project


Page Contributors                : Nathan     |  Carter      |  Salsabil     |  Haseeb
IDS (Respective order)           : 301267524    301260800      301228347       301271802

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SWS120Project.Class1;

namespace SWS120Project
{
    internal class CollegeRegistration
    {
        // Define static lists to hold information on students, faculty, courses, enrolments, and programs
        static List<Class1.course> courses = new List<Class1.course>();
        static List<Class1.enrolment> enrolments = new List<Class1.enrolment>();
        static List<Class1.student> students = new List<Class1.student>();
        static List<Class1.faculty> faculties = new List<Class1.faculty>();
        static List<Class1.collegeProgram> programs = new List<Class1.collegeProgram>();

        //validation method for int static int validInt()
        static int validInt()
        {
            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    return input;
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid number!");
                }
            }
        }

        //A simple validation method to see if the given input contains an "@" symbol as should emails
        static string validEmail()
        {
            //run until broken out
            while (true)
            {
                string input = (Console.ReadLine());

                //If input does not contain @ try again
                if (!input.Contains("@"))
                {
                    Console.WriteLine("Please Enter a valid email!");
                }
                else
                {
                    //break out the loop and return the valid email 
                    return input;
                }




            }
        }
        static void Main(string[] args)
        {

            //Create some random data for the objects so we can test
            students.Add(new Class1.student(1, "John", "Doe", "john.doe@example.com", "123-456-7890", "CS101"));
            students.Add(new Class1.student(2, "Alice", "Johnson", "alice.johnson@example.com", "234-567-8910", "CS101"));
            faculties.Add(new Class1.faculty(1, "Jane", "Smith", "jane.smith@example.com", "234-567-8901"));
            courses.Add(new Class1.course("CS101", "Introduction to Programming", 1, 3));
            courses.Add(new Class1.course("CS102", "Data Structures and Algorithms", 1, 4));
            enrolments.Add(new Class1.enrolment(1, "CS101", 1));
            enrolments.Add(new Class1.enrolment(2, "CS101", 1));
            bool running = true;

            // Run until exited
            while (running)
            {
                //menu 
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add a student");
                Console.WriteLine("2. Add a faculty member");
                Console.WriteLine("3. Add a course");
                Console.WriteLine("4. Add a program");
                Console.WriteLine("5. Enroll a student in a course");
                Console.WriteLine("6. Display student information");
                Console.WriteLine("7. Display course information");
                Console.WriteLine("8. Display all courses taken by a student");
                Console.WriteLine("9. Display all students taking a certain course");
                Console.WriteLine("10. Display all courses taught by a certain faculty");
                Console.WriteLine("11. Display all students in a certain program");
                Console.WriteLine("12. Exit");


                string input = Console.ReadLine();

                //match the user input to one of the following cases and call our methods accordingly
                switch (input)
                {
                    case "1":
                        addStudent();
                        break;
                    case "2":
                        addFaculty();
                        break;
                    case "3":
                        addCourse();
                        break;
                    case "4":
                        addProgram();
                        break;
                    case "5":
                        EnrollStudent();
                        break;
                    case "6":
                        displayStudent();
                        break;
                    case "7":
                        DisplayCourseInfo();
                        break;
                    case "8":
                        DisplayCoursesTakenByStudent();
                        break;
                    case "9":
                        DisplayStudentsTakingCourse();
                        break;
                    case "10":
                        DisplayCoursesTaughtByFaculty();
                        break;
                    case "11":
                        DisplayStudentsInProgram();
                        break;
                    case "12":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }
        }


        //method to add student 
        public static void addStudent()
        {
            Console.WriteLine("Enter student ID:");

            //call our int validation func to see if a valid input is given if it is store the value
            int studentID = validInt();
            // int studentID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();


            Console.WriteLine("Enter email:");
            string email = validEmail();

            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter program code:");
            string programCode = Console.ReadLine();

            Class1.student newStudent = new Class1.student(studentID, firstName, lastName, email, phoneNumber, programCode);
            students.Add(newStudent);

            Console.WriteLine("Student added successfully.");
        }

        //method to add faculty
        public static void addFaculty()
        {
            Console.WriteLine("Enter faculty member ID:");
            int facultyID = validInt();

            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter email:");
            string email = validEmail();

            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();

            Class1.faculty newFaculty = new Class1.faculty(facultyID, firstName, lastName, email, phoneNumber);
            faculties.Add(newFaculty);

            Console.WriteLine("Faculty member added successfully.");
        }

        //method to add a course to the list
        public static void addCourse()
        {
            Console.WriteLine("Enter course code:");
            string courseCode = Console.ReadLine();

            Console.WriteLine("Enter course name:");

            string courseName = Console.ReadLine();

            Console.WriteLine("Enter Faculty ID");

            int facultyID = validInt();

            Console.WriteLine("Enter credit hours");

            int creditHours = validInt();

            Class1.course newCourse = new Class1.course(courseCode, courseName, facultyID, creditHours);
            courses.Add(newCourse);

            Console.WriteLine("Course added successfully.");
        }

        //method to add a program to the list
        public static void addProgram()
        {
            Console.WriteLine("Enter program code:");
            string programCode = Console.ReadLine();

            Console.WriteLine("Enter program name:");
            string programName = Console.ReadLine();

            Console.WriteLine("Enter credentials:");
            string credentials = Console.ReadLine();

            Class1.collegeProgram newProgram = new Class1.collegeProgram(programCode, programName, credentials);
            programs.Add(newProgram);

            Console.WriteLine("Program added successfully.");
        }

        //method to enroll a student in a course 
        static void EnrollStudent()
        {
            Console.Write("Enter student ID: ");
            int studentId = validInt();

            Console.Write("Enter course code: ");
            string courseCode = Console.ReadLine();

            Console.Write("Enter section number: ");
            int sectionNumber = int.Parse(Console.ReadLine());

            // Create a new enrolment object and add to the list of enrolments
            Class1.enrolment newEnrolment = new enrolment(studentId, courseCode, sectionNumber);
            enrolments.Add(newEnrolment);

            Console.WriteLine("Student enrolled successfully.");
        }

        //method to display student info given their  ID
        public static void displayStudent()
        {
            Console.WriteLine("Enter student ID:");
            int studentID = validInt();

            student foundStudent = null;
            //try to find the student id in our list
            foreach (student s in students)
            {
                if (s.ID_ == studentID)
                {
                    foundStudent = s;
                    break;
                }
            }

            if (foundStudent != null)
            {
                //if found then get their info and output
                Console.WriteLine("Student ID: " + foundStudent.ID_);
                Console.WriteLine("Name: " + foundStudent.firstName_ + " " + foundStudent.lastName_);
                Console.WriteLine("Email: " + foundStudent.email_);
                Console.WriteLine("Phone: " + foundStudent.phoneNumber_);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        //method to display all the courses a student is currently taking
        static void DisplayCoursesTakenByStudent()
        {
            Console.Write("Enter student ID: ");
            int studentId = validInt();

            Console.WriteLine("Courses taken by student:");
            foreach (var enrolment in enrolments)
            {
                if (enrolment.id_ == studentId)
                {
                    Console.WriteLine($"- {enrolment.courseCode}");
                }
            }
        }

        //method to display all the courses a faculty is currently teaching    
        static void DisplayCoursesTaughtByFaculty()
        {
            Console.Write("Enter faculty ID: ");
            int facultyId = validInt();

            Console.WriteLine($"Courses taught by faculty with ID {facultyId}:");
            foreach (var course in courses)
            {
                if (course.facultyID_ == facultyId)
                {
                    Console.WriteLine($"{course.courseCode_} - {course.courseName_}");
                }
            }
        }
        //method to display all the students in a course
        static void DisplayStudentsInProgram()
        {
            Console.Write("Enter program code: ");
            string programCode = Console.ReadLine();

            Console.WriteLine($"Students in program with code {programCode}:");
            foreach (var student in students)
            {
                if (student.programCode_ == programCode)
                {
                    Console.WriteLine($"{student.ID_} - {student.firstName_} {student.lastName_}");
                }
            }

        }

        //method to display all the courses a student is currently taking a course
        static void DisplayStudentsTakingCourse()
        {
            Console.Write("Enter course code: ");
            string courseCode = Console.ReadLine();

            Console.WriteLine($"Students taking course with code {courseCode}:");
            foreach (var enrolment in enrolments)
            {
                if (enrolment.courseCode_ == courseCode)
                {
                    var student = students.Find(s => s.ID_ == enrolment.id_);
                    Console.WriteLine($"{student.ID_} - {student.firstName_} {student.lastName_}");
                }
            }
        }

        //method to display all the courses info
        static void DisplayCourseInfo()
        {
            Console.Write("Enter course code: ");
            string courseCode = Console.ReadLine();

            var course = courses.Find(c => c.courseCode_ == courseCode);
            if (course == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }

            Console.WriteLine($"Course Code: {course.courseCode_}");
            Console.WriteLine($"Course Name: {course.courseName_}");
            Console.WriteLine($"Faculty ID: {course.facultyID_}");
            Console.WriteLine($"Credit Hours: {course.creditHours_}");

            Console.WriteLine("Students enrolled:");
            foreach (var enrolment in enrolments)
            {
                if (enrolment.courseCode_ == course.courseCode_)
                {
                    var student = students.Find(s => s.ID_ == enrolment.id_);
                    Console.WriteLine($"- {student.firstName_} {student.lastName_}");
                }
            }
        }
    }

}

