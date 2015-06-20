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
            //u715();
            //u716();
            //u717();
            //u719();
            //u7110();
            //u731();
            u733();
        }

        static void u733()
        {
       
            Console.WriteLine("Är det fint väder? j/n");
            string str = Console.ReadLine();

            Console.Clear();

            if (str == "j")
            {
                Console.WriteLine("Vi går på Picknick!");
                Console.ReadLine();
            }

            else if (str == "n")
            {
                Console.WriteLine("Vi stannar inne och läser en bok!");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Jag förstår inte.");
                Console.ReadLine();
            }
        }
        static void u732()
        {

            Console.WriteLine("Är det fint väder? j/n");
            string str = Console.ReadLine();

            Console.Clear();

            if (str == "j")
            {
                Console.WriteLine("Vi går på Picknick!");
                Console.ReadLine();
            }

            else if (str == "n")
            {
                Console.WriteLine("Vi stannar inne och läser en bok!");
                Console.ReadLine();

            }
        }

        static void u731()
        {

            Console.WriteLine("Är det fint väder?");
            string str = Console.ReadLine();

            Console.Clear();

            if (str == "j") 
            {
                Console.WriteLine("Vi går på Picknick!");
                Console.ReadLine();
            }


        }

        static void u7110()
        {

            int a = 8 % 3;
            Console.WriteLine(a);
            Console.ReadLine();

            //Det som blir över efter division , % Modulus, Operatorn
        }

        static void u719()
        {
            int a = 1;
            int b = 2;
            decimal c = Convert.ToDecimal(a) / Convert.ToDecimal(b);
            Console.WriteLine(c);
            Console.ReadLine();
            //Lösning 1 - Bytte float till decimal och converterade int till decimal.

        }
        static void u717()
        {
            char myChar = (char)97;
            Console.WriteLine(myChar);
            Console.ReadLine();
        }

        static void u716()
        {
            Console.Write("Vad är en tredjedel av 100? ");
            


            string stringTal = Console.ReadLine();
               

            float floatTal = float.Parse(stringTal);

            
            double doubleTal = Math.Round(floatTal, 2) ;

            Console.Write("Avrundat till två decimaler blir talet " + doubleTal);
            Console.ReadLine();



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
