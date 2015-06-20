using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbetsboken
{
    class Program
    {
        static void Main(string[] args)
        {
            //u712();
            //u713();
            //u714();
            u715();

        }
        
        static void u715()
        {
            Console.Write("Vad heter du? ");
            string namn1 = Console.ReadLine();

            Console.Clear();

            Console.Write("Vad heter din bästa kompis? ");
            string namn2 = Console.ReadLine();

            Console.Clear();

            string de2 = String.Format("{0} och {1} brukade hitta på mycket bus tillsammans", namn1, namn2);

            Console.WriteLine("Det var en gång en liten hen som hette " + namn1);
            Console.WriteLine("Hen hade en bästa kompis som hette " + namn2);
            Console.WriteLine(de2);
            Console.WriteLine("Och det var det, det...");

            Console.ReadLine();
       
        }


        static void u714()
        {

            Console.Write("Ange ett decimaltal: ");
            string stringTal = Console.ReadLine();

            Console.Clear();

            decimal decimalTal = Convert.ToDecimal(stringTal);

            int intTal = Convert.ToInt32(decimalTal);


            Console.WriteLine("Talet avrundas till " + intTal);
            Console.ReadLine();
            
        }
        
        static void u713()
        {


            Console.Write("Mata in ett heltal: ");
            string stringTal = Console.ReadLine();

            Console.Clear();

            Console.Write("Mata in ett till heltal: ");
            string stringTal2 = Console.ReadLine();

            Console.Clear();

            Console.Write("Mata in ett sista heltal: ");
            string stringTal3 = Console.ReadLine();

            Console.Clear();

            int tal = Convert.ToInt32(stringTal);
            int tal2 = Convert.ToInt32(stringTal2);
            int tal3 = Convert.ToInt32(stringTal3);

            int totalTal = tal + tal2 + tal3;
            int medelTal = (tal + tal2 + tal3) / 3;

            Console.WriteLine("Totalt blir talen " + totalTal);

            Console.Write("Talens medelvärde är " + medelTal);
            Console.Read();
            
           
               
            
        }
    
        static void u712()
        {
            Console.Write("Mata in ett heltal: ");
            string stringTal = Console.ReadLine();

            Console.Write("Mata in ett till heltal: ");
            string stringTal2 = Console.ReadLine();

            int tal = Convert.ToInt32(stringTal);
            int tal2 = Convert.ToInt32(stringTal2);

            int totalTal = tal + tal2;

            Console.WriteLine("Totalt blir dessa talen " + totalTal);
            Console.ReadLine();
          
            
            

        }
    }
}
