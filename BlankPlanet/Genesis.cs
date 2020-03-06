using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankPlanet
{
    class Genesis
    {
        bool visitedMarket;
        bool visitedSalvageYard;
        bool visitedHordor;
        bool visitedbar;
        bool visitedtown;
        string choice;
        bool barfight;


        public void runPlanet()
        {
            {
                bool checkAgain = true;
                typewriter typewriter = new typewriter();
                typewriter.Typewrite("You are approaching the planet Genesis\n", 30);
                typewriter.Typewrite("You step out of your ship\n", 30);
                typewriter.Typewrite("You see a vast desert with a small town in the distance.\n", 30);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Visit Town?\n");

                Console.Write("1");
                Console.WriteLine(": Yes");
                Console.Write("2");
                Console.WriteLine(": No");
                Console.Write("Choice: ");

                choice = Console.ReadLine();


                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("After a long journey on foot, you finally reach the town of Hodor!");
                    Console.ReadLine();
                    Console.Clear();



                }
                else if (choice == "2" || choice.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You decided to go back to your ship!");
                    Console.ReadLine();
                    Console.Clear();
                    backtoship();

                    visitedHordor = false;
                }


                Console.Clear();
                Console.WriteLine("Where would you like to go?\n");
                Console.Write("1");
                Console.WriteLine(": Market");
                Console.Write("2");
                Console.WriteLine(": Salvage Yard");
                Console.Write("3");
                Console.WriteLine(": Bar");
                Console.Write("Choice: ");
                choice = Console.ReadLine();
                visitedHordor = false;


                if (choice == "1")
                {
                    checkAgain = false;
                    Console.Clear();
                    market();

                }

                else if (choice == "2")
                {
                    checkAgain = false;
                    Console.Clear();
                    salvageyard();
                }

                else if (choice == "3")
                {
                    checkAgain = false;
                    Console.Clear();
                    bar();
                }

            }
        }


        public void market()
        {
            bool checkAgain = true;
            visitedMarket = true;

            Console.WriteLine("You arrive at the Market.\n");
            Console.WriteLine("You see a sign that reads 'LaMarr's Acquired Emporium\n");

            Console.ReadLine();
            Console.Clear(); ;
            Console.WriteLine("LaMarr: Welcome to my store!\n");
            Console.ReadLine();
            Console.WriteLine("Would you like to take a look at my store?\n");
            Console.Write("1");
            Console.WriteLine(": Yes");
            Console.Write("2");
            Console.WriteLine(": No");
            Console.Write("Choice: ");


            choice = Console.ReadLine();



            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("Very Well\n");
                Console.ReadLine();
                Console.Clear();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Then what do you want?\n");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Get Lost!");
                Console.ReadLine();
                Console.Clear();
            }

            do
            {
                Console.WriteLine("Where would you like to go?");
                Console.Write("1");
                Console.WriteLine(": Salvage Yard");
                Console.Write("2");
                Console.WriteLine(": Bar");
                Console.Write("Choice: ");
                choice = Console.ReadLine();


                if (choice == "1" || visitedMarket == false)
                {
                    checkAgain = false;
                    Console.Clear();
                    salvageyard();
                }
                else if (choice == "1" || visitedMarket == true)
                {
                    checkAgain = true;
                    Console.Clear();
                    salvageyard();

                }
                else if (choice == "2" || visitedbar == false)
                {
                    checkAgain = false;
                    Console.Clear();
                    bar();
                }
                else if (choice == "2" || visitedbar == true)
                {
                    checkAgain = true;
                    Console.Clear();
                    bar();
                }
                else
                {
                    Console.WriteLine("I need to keep moving");
                    checkAgain = true;
                }
            } while (checkAgain == true);
        }







        public void salvageyard()
        {
            bool checkAgain = true;
            visitedSalvageYard = true;
            Console.WriteLine("You found your way to the Hodor Stolen Salvage Yard!\n");
            Console.WriteLine("You are greeted by a hologram of LaMarr the owner of the yard\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("LaMarr: Greetings Traveler. This is the salvage yard of Hordor! ");
            Console.WriteLine("LaMarr: In here you can find any thing from engines to dark matter!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("LaMarr: It's only a small charge to take a look around and grab whatever you like.");
            Console.WriteLine("LaMarr: Would you like to take a look around?");
            Console.Write("1");
            Console.WriteLine(": Yes");
            Console.Write("2");
            Console.WriteLine(": No");
            Console.Write("Choice: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("Great! Have a look around!");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("As you are searching for parts, you come along Chewie");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You: Chewie.. What an earth are you doing here?");
                Console.ReadLine();
                Console.WriteLine("Chewie: AAARARRRGWWWH");
                Console.ReadLine();
                Console.WriteLine("You: Sweet.. you found some dark matter that I was looking for. ");
                Console.ReadLine();
                Console.WriteLine("Chewie: AAARARRRGWWWHHHHHHHHh");
                Console.ReadLine();
                Console.WriteLine("You: So you're telling me your ship doesn't work anymore..?");
                Console.ReadLine();
                Console.WriteLine("You: Why don't you just tag along with me..?");
                Console.ReadLine();
                Console.WriteLine("Chewie: AAARARRRGWWWH");
                Console.ReadLine();
                Console.WriteLine("You: Great!! Lets get going..");

            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Are you done wasting my time?");
                Console.ReadLine();
                Console.Clear();
            }
            do
            {
                Console.WriteLine("Where would you like to go?");
                Console.Write("1");
                Console.WriteLine(": Bar");
                Console.Write("2");
                Console.WriteLine(": Market");
                Console.Write("3");
                Console.WriteLine(": Back to ship");

                choice = Console.ReadLine();

                if (choice == "1" || visitedbar == false)
                {
                    checkAgain = false;
                    Console.Clear();
                    bar();
                }
                else if (choice == "1" || visitedbar == true)
                {
                    checkAgain = true;
                    Console.Clear();
                    Console.WriteLine("I should go somewhere else..");
                }
                else if (choice == "2" || visitedMarket == false)
                {
                    checkAgain = false;
                    Console.Clear();
                    market();
                }
                else if (choice == "2" || visitedMarket == true)
                {
                    checkAgain = true;
                    Console.Clear();
                    Console.WriteLine("I should go somewhere else...");
                }
                else if (choice == "3" || visitedMarket == false || visitedSalvageYard == false || visitedbar == false)
                {
                    checkAgain = false;
                    Console.Clear();
                    Console.WriteLine("I should probably finish looking around..");
                }
                else if (choice == "3" || visitedMarket == true || visitedSalvageYard == true || visitedbar == true)
                {
                    checkAgain = true;
                    Console.Clear();
                    backtoship();
                }
                else
                {
                    Console.WriteLine("I need to keep moving!");
                    checkAgain = true;
                }

            } while (checkAgain == true);
        }






        public void bar()
        {
            bool checkAgain = true;
            visitedbar = true;

            Console.WriteLine("You come accross a sign hanging by one chain");
            Console.Write("This sign reads: ");
            Console.Write("Broken Arrow Bar");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You walk up to the bartender.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Bartender: Greetings, my name is Kril and welcome to the Broken Arrow Bar.");
            Console.ReadLine();
            Console.WriteLine("Kril: I have never seen you here before.");
            Console.ReadLine();
            Console.WriteLine("You: I'm just stopping through.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("As you are talking to the bartender, you get shoved by a Space Pirate");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Pirate: Hey! Watch where you are going");
            Console.ReadLine();
            Console.WriteLine("What do you want to do?");
            Console.Write("1");
            Console.WriteLine(": Stick up for yourself");
            Console.Write("2");
            Console.WriteLine(": Walk away from the Space Pirate");
            Console.Write("Choice: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("You watch where you are going!");
                Console.ReadLine();
                Console.WriteLine("The space pirate takes a swing at you..");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You dodge his punch..");
                Console.ReadLine();
                Console.WriteLine("You grab the pirates head and smash it into the bar..");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Everyone stops what they are doing and stare at you");
                Console.ReadLine();
                Console.WriteLine("What...? He had it coming..");
                Console.ReadLine();
                Console.Clear();
            }
            else if (choice == "2" || choice.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("You: I don't want any trouble..");
                Console.ReadLine();
                Console.WriteLine("Pirate: That's what I thought..! Walk Away!");
                Console.ReadLine();
                Console.Clear();
            }
            do
            {
                Console.WriteLine("Where would you like to go?");
                Console.Write("1");
                Console.WriteLine(": Salvage Yard");
                Console.Write("2");
                Console.WriteLine(": Market");
                Console.Write("3");
                Console.WriteLine(": Back to ship");
                choice = Console.ReadLine();


                if (choice == "1" || visitedSalvageYard == false)
                {
                    checkAgain = false;
                    Console.Clear();
                    salvageyard();
                }
                else if (choice == "1" || visitedSalvageYard == true)
                {
                    checkAgain = true;
                    Console.Clear();
                    Console.WriteLine("I should go somewhere else..");
                }
                else if (choice == "2" || visitedMarket == false)
                {
                    checkAgain = false;
                    Console.Clear();
                    market();
                }
                else if (choice == "2" || visitedMarket == true)
                {
                    checkAgain = true;
                    Console.Clear();
                    Console.WriteLine("I should go somewhere else...");
                }
                else if (choice == "3" || visitedMarket == false || visitedSalvageYard == false || visitedbar == false)
                {
                    checkAgain = false;
                    Console.Clear();
                    Console.WriteLine("I should probably finish looking around..");
                }
                else if (choice == "3" || visitedMarket == true || visitedSalvageYard == true || visitedbar == true)
                {
                    checkAgain = true;
                    Console.Clear();
                    backtoship();
                }
            } while (checkAgain = true);
        }
    

        


        public void backtoship()
        {
            visitedSalvageYard = true;
            visitedMarket = true;
            visitedbar = true;
            Console.WriteLine("You make your way back to your ship.");
            Console.ReadLine();
            Console.WriteLine("You Leave the Planet");
            Console.ReadLine();
            System.Environment.Exit(0);
            
        }
    }
}

    
   
       




 























