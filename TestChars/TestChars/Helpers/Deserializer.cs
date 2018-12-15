using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using TestChars.Models;
using Newtonsoft.Json;

namespace TestChars.Helpers
{
    class Deserializer
    {
        public static void DeserializerMethod1()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string JsonStr = File.ReadAllText(@"C:\Users\Sky\source\repos\JsonTest\JsonTest\Data\JsonString.json");
            Customer c1 = ser.Deserialize<Customer>(JsonStr);
            Console.WriteLine($"{c1.FirstName} {c1.LastName} {c1.Age}");
            Console.ReadLine();

        }


        public static void DeserializerMethod2() //Using JSON Nuget
        {

            string JsonStr = File.ReadAllText(@"C:\Users\Sky\source\repos\JsonTest\JsonTest\Data\JsonString.json");
            Customer c1 = JsonConvert.DeserializeObject<Customer>(JsonStr);
            Console.WriteLine($"{c1.FirstName} {c1.LastName} {c1.Age}");
            Console.ReadLine();

        }












    }
}
