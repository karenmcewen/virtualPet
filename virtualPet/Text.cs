using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class Text
    {
        //-------------------------------------------------------------
        //NOTE - THIS CLASS IS NOT USED in MVP
        //THIS IS INFO FOR ALTERNATE-ADVANCED GAME PLAY for later development
        //-------------------------------------------------------------

        //Console.WriteLine();
        //Console.WriteLine("|================================================================|");
        //Console.WriteLine("|                             oooooo                             |");
        //Console.WriteLine("|                          (O   oo    O)                         |");
        //Console.WriteLine("|                       (OO oo  --  oo OO)                       |");
        //Console.WriteLine("|                       (OO oo  --  oo OO)                       |");
        //Console.WriteLine("|                          (O   oo    O)                         |");
        //Console.WriteLine("|                             oooooo                             |");
        //Console.WriteLine("|================================================================|");
        //Console.WriteLine();

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
        // Console.WriteLine("Number of Buds: {0}", bloop.CurrentNumBuds);
        //Console.WriteLine("isAnnoyed? {0}", bloop.IsAnnoyed);

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
                        
         
         ENDGAME
          Console.WriteLine("The Bleeps are sorry to see you go.");
            Console.WriteLine("You get in your rocket ship and fly away.");
            Console.WriteLine("----____----____----____----____>>>))))))))))))>");
            */

    }
}
