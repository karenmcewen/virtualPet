using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requirements - Main method
            //Interactive user interface (see example at bottom of page)
            //Display current status of pet
            //Display options for interacting with pet
            //Ask user what action to take
            //User's selection should trigger an action


            //Introduction 
            //Console.WriteLine("Welcome to Planet X");
            //Console.WriteLine("Sadly, the planet's inhabitants, the Bleeps, have become nearly extinct.");
            //Console.WriteLine("Only a single, sad and sickly Bloop remains.");

            ////NTS-move this section to a separate thing that can be accessed again by typing 'help'
            //Console.WriteLine("As the universe's best xenobiologist, you have been called here to save the species!");
            //Console.WriteLine("Your job is to nurture the last Bloop back to health and happiness,");

            //Console.WriteLine("A happy and healthy Bloop with enough energy begins to bud.");
            //Console.WriteLine("Once three buds appear, and all are filled with energy,");
            //Console.WriteLine("the buds blow up and are released by the Bloop, leaving the Bloop and its ");
            //Console.WriteLine("three baby Bleeps tired, but ready to start the cycle again.");
            //Console.WriteLine("Because the Bleeps are all psychically connected, each will do exactly the same as the parent Bloop");
            //Console.WriteLine("and, in time, will bud themselves, blow up, and breed more Bleeps.");
            //Console.WriteLine("If you take care of them, soon the planet will be repopulated!");
            //Console.WriteLine("Bleeps are known to be fun-loving and gentle creatures, but beware!");
            //Console.WriteLine("If you annoy them too much, they will be bothered, and will send you away.");
            //NTS-end moved section

            Console.WriteLine("Are you ready to begin?(yes/no)");

            string begin = Console.ReadLine().ToLower();

            while (begin != "yes")
            {
                Console.WriteLine("Are you ready to begin now?");
                begin = Console.ReadLine().ToLower();
            }

            //starting values


            //int numBuds = 3; //number of offspring (bleeps) from a single popation
            //int totalBleeps = 1; //total number of original plus all offspring and grand offspring and great-grand...etc.
            //int bleepsToRePopulate = 100;//number of podi needed to repopulate the planet


            //ask to rename the Bloop

            //Console.WriteLine("The Bloop's name is Blobbi");
            //Console.WriteLine("Would you like to rename your Bloop?");
            //Console.WriteLine("1) yes");//starts out sad :(
            //Console.WriteLine("2) no");//starts out happy :)!
            //int answerName = int.Parse(Console.ReadLine());
            //switch (answerName)
            //{
            //    case 1:
            //        Console.WriteLine("You chose to rename your Bloop");
            //        Console.WriteLine("What would you like to call your Bloop?");
            //        string newBloopName = Console.ReadLine();
            //        Bleeps bloop = new Bleeps(newBloopName);
            //        string name = bloop.BloopName;
            //        Console.WriteLine("Renaming your Bloop {0} has made it sad. Lucky for you, Bleeps have short memories!", name);
            //        break;

            //    default:
            //        Bleeps bloop = new Bleeps();
            //        string name = bloop.BloopName;
            //        Console.WriteLine("That's a great name! I'm glad to meet you, {0}!", name);
            //        break;               

            //}

            
            Bleeps bloop = new Bleeps();
            bool keepPlaying = true;

            do
            {

                //Menu INTERFACE (shows each time)
                Console.WriteLine("Current status of {0} the Bloop: ", bloop.BloopName);
                Console.WriteLine("Energy: {0}", bloop.CurrentEnergy);
                Console.WriteLine("Number of Buds: {0}", bloop.CurrentNumBuds);
                Console.WriteLine("isHappy? {0}", bloop.IsHappy);
                Console.WriteLine("isAnnoyed? {0}", bloop.IsAnnoyed);
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1) Play in the moonlight 2) Juggle 3) Sing 4) Quit");
                Console.WriteLine();

                int choiceToDo = int.Parse(Console.ReadLine());
                switch (choiceToDo)
                {
                    case 1:
                        bloop.Energize();
                        break;
                    case 2:
                        bloop.Juggle();
                        break;
                    case 3:
                        bloop.Sing();
                        break;
                    case 4:
                        EndGame();
                        keepPlaying = false;
                        break;
                    default:
                        Console.WriteLine("You are sitting. Nothing is happening. Ho hum.");
                        break;
                }

            }
            while (keepPlaying == true);


            /*NTS - this is the advanced stuff - finish the MVP first!
                        while (totalBleeps < bleepsToRePopulate)
                        {
                            //this is the main part of the program

                            //show menu - either three different menus based on what is available, or one master menu and respond to user n/a
                            //Eat() to get energy, Play() to be happy
                            //if energy (>=20), grows another bud Bud()
                            //if isHappy (true) and numBuds (=3) and energy (>=20) then creates offspring -->BlowsUp()

            
                        }
                        //you win!

                        Console.WriteLine("Congratulations! There are now {0} Bleeps. You have saved the species!", totalBleeps);
                        */


            /////////// end of main here ///////////////////////
        }
        //CREATING NEW METHODS That can be called over and over again
        //"public" is an access modifier - who has access to the program
        //"int" is the return type of the data "void" doesn't return anything
        //"Add" is the name of the method - begin with uppercase/pascal case
        //each method should do only one thing
        //elements in the () are the parameters
        //elements in the {} is the body

        public static bool EndGame()
        {
            Console.WriteLine();
            Console.WriteLine("The Bleeps are sorry to see you go.");
            Console.WriteLine("You get in your rocket ship and fly away.");
            Console.WriteLine("...................................................>(====)>");
            bool keepPlaying = false;
            return keepPlaying;

        }
    }
}
