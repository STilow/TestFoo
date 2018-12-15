using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using TestChars.Models;
using Newtonsoft.Json;

namespace JsonTest.Helpers
{
    public class Serializer
    {

        public static void SerializerMethod2()
        {
            string JsonString = JsonConvert.SerializeObject(new Customer()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Rambo",
                Age = 70
            });
            Console.WriteLine(JsonString);
            Console.ReadLine();
        }

        public static void SerializerMethod1()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string JsonString = ser.Serialize(new Customer()
            {
                Id = 2,
                FirstName = "John",
                LastName = "Rambo",
                Age = 70
            });
            Console.WriteLine(JsonString);
            Console.ReadLine();
            File.WriteAllText(@"C:\Users\Sky\source\repos\JsonTest\JsonTest\Data\output.json", JsonString);
        }

    }
}

