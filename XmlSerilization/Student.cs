using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
    {
    [XmlRoot ("std")]
    public class Student
        {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Section { get; set; }

        public Student ()
            {
            this.FirstName = "Muhammd";
            this.LastName = "Ali";
            this.Email = "muhammd.ali@gamil.com";
            this.Section = "B Teck 14";
            }
        public Student (string fName, string lName, string email, string sec)
            {
            this.FirstName = fName;
            this.LastName = lName;
            this.Email = email;
            this.Section = sec;
            }
        public List<Student> GetStudents ()
            {
            return new List<Student> ()
                {
                new Student("Muammad","Abdullah","mb@hotmail.com","M Tech F12"),
                new Student("Ali","Muhammad","ali@gmail.com","M Tech F13")
                };
            }
        }
    }