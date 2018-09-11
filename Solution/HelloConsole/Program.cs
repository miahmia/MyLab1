using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

           

            if (args.Length > 0)
            {
                if (args.Length == 1){
                    Console.WriteLine("Hello, " + args[0] + "!");
                     }

                else if (args.Length == 2) {

                    try  {
                        int ageOverOne = Int32.Parse(args[1]);

                        if (ageOverOne > 1)   {
                            Console.WriteLine(args[0] + " is " + args[1] + " years old.");
                        }

                        else  {
                            Console.Write("Next time enter a number over 1");
                        }
                    }

                    catch (Exception e)
                    {
                        Console.Write("Next time enter a number over 1. " + e.ToString());
                    }
                }


                else if (args.Length == 3)
                {
                    Console.Write("Too many parameters");
                }
            }

            else    {
                Console.WriteLine("Type your first name and press Enter");
                var name = Console.ReadLine();
                Console.WriteLine("Hello, " + name + "!");

                Console.WriteLine("Type your age and press Enter");
                var age = Console.ReadLine();
                Console.WriteLine(name + " is " + age + " years old.");

            }
            


            Console.ReadKey();
            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
