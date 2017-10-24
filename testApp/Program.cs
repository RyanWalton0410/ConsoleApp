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
			//Variable for KeyChar
			var ansys = Console.ReadKey();
			
			Console.WriteLine("Okay " + name + " You're on a mission.. Do you want to hear more?");
			Console.WriteLine("\n(Y)es\n(N)o");
if (ansys.KeyChar == 'y' || ansys.KeyChar == 'Y')
			{
				//Handle yes case
				Console.WriteLine("Sweet!, Okay so I know you're blind an all so i'll describe where we are at.. we are stuck on a spaceship and we need your help do you accept?");
				Console.ReadKey();
			if (ansys.KeyChar == 'y' || ansys.KeyChar == 'Y')
				{
					//handles yes case for the previous initial yes case 
					Console.WriteLine("Okay so I don't know where we need to go the door to the left for Right");
					Console.WriteLine("\n(1)Left \n(2)Right");
					Console.ReadKey();
				if (ansys.KeyChar == '1')
					{
					  Console.WriteLine("This looks very... ominous, I dont like this");
					  Console.WriteLine("\n(Y)es \n(N)o");
					}
					
						if(ansys.KeyChar == 'y' || ansys.KeyChar == 'Y')
						{
						
						}
						if(ansys.KeyChar == 'n' || ansys.KeyChat == 'N')
						{
							
						}
						
					
					if(ansys.KeyChar == 'n' || ansys.KeyChar == 'N')
					{
                       				 //Handles No case with an else method
						Console.WriteLine("it's Bright... almost to bright I dont like this");
						Console.WriteLine("\n(Y)es \n(N)o");
					}
				}

			if (ansys.KeyChar == 'n' || ansys.KeyChar == 'N')
				{
					//Handle no case
					Console.WriteLine("Cmon sir we really need you to help us.. it's.. I need help sir.. please ");
	if (ansys.KeyChar == 'n' || ansys.KeyChar == 'N')
					{
                        //Quit cheating.
						Console.WriteLine("Fine have it your way");
						System.Threading.Thread.Sleep(5000);
                        //closes app
						Environment.Exit(0);
					}
					else
					{
						Console.WriteLine();
						Console.WriteLine("Enter letters only");
					}
				}
			}
		}
	}
}
