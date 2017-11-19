using System;
using System.IO;
using System.Xml; 
using System.Xml.Serialization; 

namespace XmlSerialization
    {
    internal class XmlConvert
        {
        /// <summary>
        /// Serializ an object into the equivalent XML string
        /// </summary>
        /// <param name="Object">The object to be serialized into XML</param>
        /// <returns>The serialized xml string</returns>
        internal static string SerializeObject<T> (T Object)
            {
            try
                {
                XmlSerializer xmlSerializer = new XmlSerializer (typeof (T));

                using (var stringWriter = new StringWriter ())
                    {
                    using (XmlWriter writer = XmlWriter.Create (stringWriter))
                        {
                        xmlSerializer.Serialize (writer, Object);
                        return stringWriter.ToString ();
                        }
                    }
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        /// <summary>
        /// Serializ an object into the equivalent XML string
        /// </summary>
        /// <param name="Object">The object to be serialized into XML</param>
        /// <param name="Path">A relative or absolute path for the file that the current FileStream object will encapsulate.</param>
        /// <returns>The serialized xml string</returns>
        internal static void SerializeObject<T> (T Object, string Path)
            {
            try
                {
                XmlSerializer xmlSerializer = new XmlSerializer (typeof (T));

                using (FileStream fs = new FileStream (Path, FileMode.Create))
                    {
                    xmlSerializer.Serialize (fs, Object);
                    }
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }

        /// <summary>
        /// Deserializ XML string into the equivalent Objects
        /// </summary>
        /// <param name="Path">A relative or absolute path for the xml file </param>
        /// <returns>The deserialized object</returns>

        internal static T DeserializeObjects<T> (string path)
            {
            T xmlResults = default (T);
            try
                {
                XmlSerializer serializer = new XmlSerializer (typeof (T));

                using (StreamReader reader = new StreamReader (path))
                    {
                    xmlResults = (T)serializer.Deserialize (reader);
                    reader.Close ();
                    }
                }
            catch (Exception ex)
                {
                Console.WriteLine (ex.Message);
                }
            return xmlResults;
            }
        }
    }
