using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Opration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to CRUD operatins using Arraylist and Dictionary collection ***\n ");

            
            Console.WriteLine("Enter \n 1. for ArrayList collection\n " +
                "2. for Dictionary collection");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Crud_ArrayList.ArrayList1();
                    break;

                    case 2:
                    Crud_Dictionary.Dictionary1();
                    break;
            }
           
        }
            
    }
}