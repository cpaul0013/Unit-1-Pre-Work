using System;

namespace Time_Travel_Mayhem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while(keepGoing == true)
            {
                Console.Write("Please select a unit of measurement : inch, fidget spinners, foot, or memes: ");
                string unitMeasure = Console.ReadLine();
                Console.Write("Please insert a number: ");
                double unitNumber = double.Parse(Console.ReadLine());
                if(unitMeasure == "inch")
                {
                    double conversion = unitNumber * 3.5;
                    Console.WriteLine(unitNumber + " " + unitMeasure + " is equal to" + " " + conversion + " fidget spinners.");
                }
                else if(unitMeasure == "fidget spinners")
                {
                    double conversion = unitNumber / 3.5;
                    Console.WriteLine(unitNumber + " " + unitMeasure + " is equal to" + " " + conversion + " inches.");
                }
                else if(unitMeasure == "foot")
                {
                    double conversion = unitNumber * 5;
                    Console.WriteLine(unitNumber + " " + unitMeasure + " is equal to" + " " + conversion + " memes.");
                }
                else if(unitMeasure == "memes")
                {
                    double conversion = unitNumber / 5;
                    Console.WriteLine(unitNumber + " " + unitMeasure + " is equal to" + " " + conversion + " foot / feet.");
                }
                Console.Write("Would you like to convert another value? Y or N ");
                string reply = Console.ReadLine();
                if(reply == "Y" || reply == "y")
                {
                    keepGoing = true;
                }
                else
                {
                    keepGoing = false;
                }
                    
            }

        }
    }
}
