using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XmlSerialization;

namespace XmlSerialization
    {
    [XmlRoot ("Class")]
    public class StudentClass
        {

        public List<Student> Students { get; set; }

        //[XmlArray ("Students")]
        //public List<Student> ListOfStudents { get; set; }
        }
    }
