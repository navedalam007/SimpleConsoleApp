using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    public class Class1
    {
        public string carmodele;
       public  int caryear;
        public Class1( string model , int  yaer)
        {
            carmodele = model;
            caryear = yaer;
            //  Console.WriteLine("Class1 class Calling");
            Console.WriteLine("Car Mode: " + carmodele + " And Car Yaer is: " + caryear);
        }

        public Class1(int  yaer, string model)
        {
            carmodele = model;
            caryear = yaer;
            //  Console.WriteLine("Class1 class Calling");
            Console.WriteLine("Car Model: " + carmodele + " And Car Yaer is: " + caryear);
        }

        public void Display()
        {
           
        }
      
    }
}
