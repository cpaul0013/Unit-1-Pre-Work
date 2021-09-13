using System;

namespace Chat_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What would you like to say to the bot?: hello, bye, sup, hello there ");
            string response = Console.ReadLine();
            response.ToLower();
            bool keepTalking = true;
            while (keepTalking == true)
            {
                if (response == "hello")
                {
                    Console.WriteLine("Hi good to see you");

                    bool helloResponse = false;
                    while (helloResponse == false)
                    {
                        Console.Write("What would you like to say to the bot?: hello, bye, sup, hello there ");
                        string response2 = Console.ReadLine();
                        response = response2;
                        if (response == "hello")
                        {
                            Console.WriteLine("I am sorry you have already said that.");
                        }
                        else { helloResponse = true; }
                    }

                }
                else if (response == "sup")
                {
                    Console.WriteLine("I am good.");
                    bool supResponse = false;
                    while (supResponse == false)
                    {
                        Console.Write("What would you like to say to the bot?: hello, bye, sup, hello there ");
                        string response2 = Console.ReadLine();
                        response = response2;
                        if (response == "sup")
                        {
                            Console.WriteLine("I am sorry you have already said that.");
                        }
                        else { supResponse = true; }
                    }
                }
                else if (response == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                    bool helloThereResponse = false;
                    while (helloThereResponse == false)
                    {
                        Console.Write("What would you like to say to the bot?: hello, bye, sup, hello there ");
                        string response2 = Console.ReadLine();
                        response = response2;
                        if (response == "hello there")
                        {
                            Console.WriteLine("I am sorry you have already said that.");
                        }
                        else { helloThereResponse = true; }

                    }
                }
                else { Console.WriteLine("Good bye!");
                    keepTalking = false;
                }
            }
        }
    }
}
