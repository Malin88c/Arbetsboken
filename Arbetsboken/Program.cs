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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Meny");
                Console.WriteLine("0. Avsluta");
                Console.WriteLine("1. Summan av två tal");
                Console.WriteLine("2. Summan och medelvärdet av tre tal");
                Console.WriteLine("3. Decimaltal till heltal");
                Console.WriteLine("4. En saga med två stringvariabler");
                Console.WriteLine("5. Avrunda flyttal");
                Console.WriteLine("6. Char");
                Console.WriteLine("7. Felaktiga variabeltyper");
                Console.WriteLine("8. Operatorn %");
                Console.WriteLine("9. Kontrollera vädret del 1");
                Console.WriteLine("10. Kontrollera vädret del 2");
                Console.WriteLine("11. Kontrollera vädret del 3");
                Console.WriteLine("12. Var är det kallast? del 1");
                Console.WriteLine("13. Var är det kallast? del 2");
                Console.WriteLine("14. Felaktig if-sats");
                Console.WriteLine("15. Banksimulator");
                Console.WriteLine("16. Skriva ut en talföljd 1-20");
                Console.WriteLine("17. Skriva ut en talföljd upp till 100");
                Console.WriteLine("18. Krona eller klave");
                Console.WriteLine("19. Felaktig loop");
                Console.WriteLine("20. Yatzy");
                
                Console.WriteLine();
                Console.WriteLine("Välj den siffra som motsvarar programmet du vill köra");
                int val = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (val)
                {
                    case 0:
                        return;
                    case 1:
                        u712();
                        break;
                    case 2:
                        u713();
                        break;
                    case 3:
                        u714();
                        break;
                    case 4:
                        u715();
                        break;
                    case 5:
                        u716();
                        break;
                    case 6:
                        u717();
                        break;
                    case 7:
                        u719();
                        break;
                    case 8:
                        u7110();
                        break;
                    case 9:
                        u731();
                        break;
                    case 10:
                        u732();
                        break;
                    case 11:
                        u733();
                        break;
                    case 12:
                        u734();
                        break;
                    case 13:
                        u735();
                        break;
                    case 14:
                        u736();
                        break;
                    case 15:
                        u742();
                        break;
                    case 16:
                        u751();
                        break;
                    case 17:
                        u752();
                        break;
                    case 18:
                        u753();
                        break;
                    case 19:
                        u754();
                        break;
                    case 20:
                        u755();
                        break;
                    default:
                        Console.WriteLine("Ogiltligt val!");
                        break;
                }

             
            }
            
        }
        static void u755()
        {

        }

        static void u754()
        {
            string str;
            do
            {
                Console.WriteLine("Vill du fortsätta loopen?");
                str = Console.ReadLine();
            }   while (str == "j"); //Saknades ett = tecken
        }

        static void u753()
        
        {

        }
        static void u752()
        {

        }
        static void u751()
        {

            int tal = 1;
            do
            {
                Console.WriteLine(tal);
                tal++;
            }   while (tal < 21);    

           
            Console.ReadLine();
            }


        static void u742()
        {
            while (true)
            {
                Console.WriteLine("[I]nsättning");
                Console.WriteLine("[U]ttag");
                Console.WriteLine("[S]aldo");
                Console.WriteLine("[A]vsluta");

                string val = Console.ReadLine();
                Console.Clear();
                
                switch (val)
                {
                    case "I":
                    break;
                   

                    case "U":
                    break;

                    case "S":
                    break;

                    case "A":
                    break;

                    default:
                    Console.WriteLine("Felaktigt val.");
                    break;
                   
                    
                }

                           }
        }

        static void u736()
        {
            // Det saknades ett = tecken i parantesen. + var är inget bra namn.
            int var = 10;
            if (var == 10)
                Console.WriteLine("den är 10!");
        }
        static void u735()
        {
            Console.Write("Ange temperaturen för Östersund: ");
            int ostersund = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ange temperaturen för Åmål: ");
            int amal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ange temperaturen för Arboga: ");
            int arboga = Convert.ToInt32(Console.ReadLine());

            if ((ostersund < amal) && (ostersund < arboga))
            {
                Console.WriteLine("Det är kallast i Östersund.");
            }
            else if ((amal < arboga) && (amal < ostersund))
            {
                Console.WriteLine("Det är kallast i Åmål.");
            }
            else
            {
                Console.WriteLine("Det är kallast i Arboga.");
            }
            Console.ReadLine();
        }
        static void u734()
        {
            Console.Write("Hur många grader är det i Östersund? ");
  
            string osund = Console.ReadLine();

            
            Console.Clear();


            Console.Write("Hur många grader är det i Åmål? ");
           
            string amal = Console.ReadLine();

            Console.Clear();

            int osundInt = Convert.ToInt32(osund);
            int amalInt  = Convert.ToInt32(amal);

           
            if (amalInt < osundInt)
            {
                Console.Write("Det är kallast i Åmål.");
            }
            else if (osundInt < amalInt)
            {
                Console.Write("Det är kallast i Östersund.");
            }
            else 
            {
                Console.Write("Det är lika varmt eller kallt på båda orterna.");
            }
            
            Console.ReadLine();
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
