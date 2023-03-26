using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Opration
{
    internal class Crud_Dictionary
    {
        public static void Dictionary1()
        {

            // Creating Dictionary

            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            // (or)   var dictionary1 = new Dictionary<string, string>();

            //Adding values
            dictionary1.Add(1, "One");
            dictionary1.Add(3, "Three");
            dictionary1.Add(2, "Two");
            Console.WriteLine("\n===> Adding values");
            foreach(var item in dictionary1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n===> Adding Cities");
            var cities = new Dictionary<string, string>()
            {
                {"Wardha","Higanghat, Pulgaon" },
                {"Nagpur","Kalmeshvar,Buttibori" }
            };
            foreach (KeyValuePair<string, string> kvp in cities)  // also use -- foreach(var k in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("\n Cities at Wardha : " + cities["Wardha"]);

            //Update key values
            Console.WriteLine("\n ===> After updating key values");
            cities["Wardha"]="Seloo,Savangi";
            for(int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key : {0} , Value : {1} ",cities.ElementAt(i).Key,cities.ElementAt(i).Value);
            }

            //Remove elements
            Console.WriteLine("\n ===> Removing elements");
            cities.Remove("Wardha");
            
            foreach (var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("\n Total Elements: {0}", cities.Count); // give total keys present here gives = 1

            cities.Clear(); // cleasr all data
            Console.WriteLine("\n Total Elements: {0}", cities.Count);
        }
    }
}