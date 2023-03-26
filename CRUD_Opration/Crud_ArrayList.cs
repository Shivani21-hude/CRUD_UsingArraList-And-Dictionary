using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Opration
{
    internal static class Crud_ArrayList
    {
        public static void List()
        {
            //creating arraylist 
            //ArrayList is a non-generic collection of objects

            ArrayList arraylist1 = new ArrayList();
            // (or)
            //var arralist1 = new ArrayList();
            
            //retrive data
            arraylist1.Add(10);
            arraylist1.Add("shivani");
            arraylist1.Add(null);
            arraylist1.Add(true);
            arraylist1.Add(4.5);

            Console.WriteLine("===> Arraylist 1 elements ---");
            for (int i = 0; i < arraylist1.Count; i++)
            {
                Console.WriteLine(arraylist1[i]);
            }

            Console.WriteLine("\n ===> Arraylist 2 elements ---");
            var arraylist2 = new ArrayList()
                {
                    20,"hude",null,true                           
                };
            
            for(int i=0;i<arraylist2.Count;i++)
            {
                Console.WriteLine(arraylist2[i]);
            }
            //arraylist1.AddRange(arraylist2);   --- AddRamge( )  use to add an entire list

            //Update data using ----  name.Insert(position,value)
            Console.WriteLine("\n ===> After updating ArrayList 1");
            arraylist1.Insert(1, "Second item");
            arraylist1.Insert(2, 2.5f);
           
            for (int i =0;i<arraylist1.Count;i++)
            {
                Console.WriteLine(arraylist1[i]);           //10   Second item   2.5   shivani    True   4.5                
            }

            //merge 2 arraylist object values
            Console.WriteLine("\n ===> Merging 2 arraylist values");
           
            arraylist1.InsertRange(2, arraylist2);

            foreach (var item in arraylist1) 
                Console.Write(item + ", ");      // 10, Second item, 20, hude, , True, 2.5, shivani, , True, 4.5,

            Console.WriteLine("\n ");

            // Delete value  using ---- Remove()

            Console.WriteLine("===> Deleting particular values ");
            arraylist1.Remove(null);          //Removes first occurance of null
            arraylist1.RemoveAt(4);           //Removes element at index 4
            arraylist1.RemoveRange(0, 2);     //Removes two elements starting from 1st item (0 index)

            foreach(var item in arraylist2)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}
