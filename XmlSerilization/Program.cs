using System;
using System.IO;
using System.Xml.Linq;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serilized Single Object
            SerializeSingleObject();

            //Serilized Multiple Object
            string xmlFilePath = SerializedMultipleObjects();
            Console.WriteLine("XML File Path:" + xmlFilePath);

            StudentClass students = XmlConvert.DeserializeObjects<StudentClass>(xmlFilePath);
            Console.ReadLine();
        }
        private static void SerializeSingleObject()
        {
            string path = Directory.GetCurrentDirectory() + "\\SerializeSingleObject.xml";
            Student student = new Student();
            string xmlString = XmlConvert.SerializeObject(student);
            Console.WriteLine(XDocument.Parse(xmlString).ToString());
        }
        private static string SerializedMultipleObjects()
        {
            string path = Directory.GetCurrentDirectory() + "\\SerializedMultipleObjectsSerializedMultipleObjects.xml";
            Student student = new Student();
            var students = student.GetStudents();
            StudentClass _class = new StudentClass();
            _class.Students = students;
            string xmlString = XmlConvert.SerializeObject(_class);
            XmlConvert.SerializeObject(_class, path);
            Console.WriteLine(XDocument.Parse(xmlString).ToString());

            return path;
        }
    }
}
