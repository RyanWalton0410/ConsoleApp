using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Please tell me your name");

            string name = (Console.ReadLine());
            
            Console.WriteLine("Is " + name + " ok?");
            Console.WriteLine("\n(Y)es\n(N)o");

           
           
            var ansys = Console.ReadKey();
            
            Console.WriteLine(name + "You're on a mission.. Do you want to hear more?");
            Console.WriteLine("\n(Y)es\n(N)o");

            if (ansys.KeyChar == 'y' || ansys.KeyChar == 'Y')
            {
                //Handle yes case
                Console.WriteLine("");
                
            }
            if (ansys.KeyChar == 'n' || ansys.KeyChar == 'N')
            {
                //Handle no case
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Enter letters only");
            }

       
        }

    }
}

