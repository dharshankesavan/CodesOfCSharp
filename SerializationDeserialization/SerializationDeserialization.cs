using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializationDeserialization
{
    class SerializationDeserialization
    {
        static void Main(string[] args)
        {
            string Name = "XYZ";
            string Phone = "12345";
            string DateOfBirth = "01-01-2020";
            SerializeValues(Name, Phone, DateOfBirth);
            DeserializeValues();
            Console.ReadKey();
        }
        private static void SerializeValues(string name, string phone, string dateofbirth)
        {
            EmployeeRecords emp = new EmployeeRecords
            {
                Name = name,
                Phone = phone,
                DateOfBirth = dateofbirth
            };

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream("employee.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, emp);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Exception:- " + Ex.Message);
            }
        }
        private static void DeserializeValues()
        {
            EmployeeRecords emp = new EmployeeRecords();

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsin = new FileStream("employee.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    emp = (EmployeeRecords)bf.Deserialize(fsin);
                    Console.WriteLine(string.Format("Name:- {0} and Phone:- {1}",emp.Name,emp.Phone));
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Exception:- " + Ex.Message);
            }
        }
    }
    [Serializable]
    public class EmployeeRecords
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        [NonSerialized]
        public string DateOfBirth;
    }
}
