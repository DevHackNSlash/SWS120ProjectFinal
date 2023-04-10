using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SWS120Project.Class1;

namespace SWS120Project
{
    internal class Class1
    {
        public class Person
        {
            int ID;
            string firstName;
            string lastName;
            string email;
            string phoneNumber;

            //properties
            public int ID_
            {
                get { return ID; }
                set { ID = value; }
            }
            public string firstName_
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public string lastName_
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string email_
            {
                get { return email; }
                set { email = value; }
            }
            public string phoneNumber_
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }
        }

        public class student : Person
        {
            public string programCode;


            public string programCode_
            {
                get { return programCode; }
                set { programCode = value; }
            }

            public student(int ID, string firstName, string lastName, string email, string phoneNumber, string programCode)
            {
                this.ID_= ID;
                this.firstName_ = firstName;
                this.email_ = email;
                this.lastName_ = lastName;
                this.phoneNumber_ = phoneNumber;    
                this.programCode_ = programCode;
            }

            public static void showStudentInfo()
            {
                Console.WriteLine();
            }
        }

        public class faculty : Person
        {

            public faculty(int ID, string firstName, string lastName, string email, string phoneNumber)
            {
                this.ID_ = ID;
                this.firstName_ = firstName;
                this.email_ = email;
                this.lastName_ = lastName;
                this.phoneNumber_ = phoneNumber;
                
            }
        }

        public class course
        {
            public string courseCode;
            public string courseName;
            public int facultyID;
            public int creditHours;

            public string courseCode_
            {
                get { return courseCode; }
                set { courseCode = value; }
            }

            public string courseName_
            {
                get { return courseName; }
                set { courseName = value; }
            }

            public int creditHours_
            {
                get { return creditHours; }
                set { creditHours = value; }
            }

            public int facultyID_
            {
                get { return facultyID; }
                set { facultyID = value; }
            }

           public course(string courseCode, string courseName, int facultyID, int creditHours)
            {
                this.facultyID_ = facultyID;
                this.creditHours_ = creditHours;
                this.courseCode_ = courseCode;
                this.courseName_ = courseName;
            }

            
        }

        public class enrolment
        {
            public int id;
            public string courseCode;
            public int sectionNum;

            public int id_
            {
                get { return id; }
                set { id = value; }
            }
            public string courseCode_
            {
                get { return courseCode; }
                set { courseCode = value; }
            }

            public int sectionNum_
            {
                get { return sectionNum; }
                set { sectionNum = value; }
            }
            public enrolment(int id, string courseCode, int sectionNum)
            {
                this.id_ =id;
                this.courseCode_ = courseCode;
                this.sectionNum_= sectionNum;
            }
        }
            public class collegeProgram
            {

                public string programCode;
                public string programName;
                public string credentials;

                public string programCode_
                {
                    get { return programCode; }
                    set { programCode = value; }
                }
                public string programName_
                {
                    get { return programName; }
                    set { programName = value; }
                }
                public string credentials_
                {
                    get { return credentials; }
                    set { credentials = value; }
                }
            public collegeProgram(string programCode, string programName, string credentials)
            {
                this.programCode_ = programCode;
                this.programName_ = programName;
                this.credentials_= credentials;
            }

            }
        
    }
}
            
                

                
            