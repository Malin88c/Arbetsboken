using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbetsboken
{
    public class Prov1
    {
        public void method1()
        {
             
            Console.WriteLine("1. Välkommen!");
            Console.WriteLine("2. Jobba på!");
            Console.WriteLine("3. Avsluta!");
             
            int val = int.Parse(Console.ReadLine());

            switch (val)
            {
                 case 1: 
                 Console.WriteLine("Välkommen!");
                 break;

                 case 2:
                 Console.WriteLine("Jobba på!"); 
                 break;

                 case 3:
                 Console.WriteLine("Avsluta!");
                 break;

                 default:
                 Console.WriteLine("Felaktigt val");
                 break;
            }
        
           
    }

    }
}
