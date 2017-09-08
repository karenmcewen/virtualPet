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
            Console.WriteLine("Welcome to Planet X");
            Console.WriteLine("Sadly, the planet's inhabitants, the Bleeps, have become nearly extinct.");
            Console.WriteLine("Only a single, sad and sickly Bloop remains.");

            //NTS-move this section to a separate thing that can be accessed again by typing 'help'
            Console.WriteLine("As the universe's best xenobiologist, you have been called here to save the species!");
            Console.WriteLine("Your job is to nurture the last Bloop back to health and happiness,");

            Console.WriteLine("A happy and healthy Bloop with enough energy begins to bud.");
            Console.WriteLine("Once three buds appear, and all are filled with energy,");
            Console.WriteLine("the buds blow up and are released by the Bloop, leaving the Bloop and its ");
            Console.WriteLine("three baby Bleeps tired, but ready to start the cycle again.");
            Console.WriteLine("Because the Bleeps are all psychically connected, each will do exactly the same as the parent Bloop");
            Console.WriteLine("and, in time, will bud themselves, blow up, and breed more Bleeps.");
            Console.WriteLine("If you take care of them, soon the planet will be repopulated!");
            Console.WriteLine("Bleeps are known to be fun-loving and gentle creatures, but beware!");
            Console.WriteLine("If you annoy them too much, they will be bothered, and will send you away.");
            //NTS-end moved section

            Console.WriteLine("Are you ready to begin?(yes/no)");

            string begin = Console.ReadLine().ToLower();

            while (begin != "yes")
            {
                Console.WriteLine("Are you ready to begin now?");
                begin = Console.ReadLine().ToLower();
            }

            //starting values


            int numBuds = 3; //number of offspring (bleeps) from a single popation
            int totalBleeps = 1; //total number of original plus all offspring and grand offspring and great-grand...etc.
            int bleepsToRePopulate = 100;//number of podi needed to repopulate the planet


            //ask to rename the Bloop

            Console.WriteLine("The Bloop's name is Blobbi");
            Console.WriteLine("Would you like to rename your Bloop?");
            Console.WriteLine("1) yes");//starts out sad :(
            Console.WriteLine("2) That's a great name! I'm glad to meet you, Blobbi!");//starts out happy :)!
            int answerName = int.Parse(Console.ReadLine());
            if (answerName == 1)
            {
                Console.WriteLine("What would you like to call your Bloop?");
                //NTS name can't be defined here, pass from the class...
                //NTS set isHappy to false - or just pass it from the definition??
                //NTS invoke Bleeps(bloopName)
            }
            else
            {
                //set isHappy is true
                //invoke Bleeps()
            }

            //INTERFACE (shows each time)
            //Example - Horace the Hippo
            //Hunger: 27
            //Thirst: 5
            //Boredom: 5
            //Tiredness: 50

            //What do you want to do?
            //1.Feed Horace
            //2.Water Horace
            //3.Play with Horace
            //4.Put Horace to sleep
            //5.Do nothing

            Console.WriteLine("{0} the Bloop",Bleeps.bloopName);//need to pass this from the class?
            Console.WriteLine("Energy: {0}",);


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


            /////////// here there be dragons - don't delete these 3 curly brackets!
        }
    }
}
