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
            //+Interactive user interface (see example at bottom of page)
            //+Display current status of pet
            //+Display options for interacting with pet
            //+Ask user what action to take
            //+User's selection should trigger an action
            //-Stretch task "tick"

            //This program is a virtual pet Bloop from the planet Bleep (see INTRODUCTION below)
            //there are two additional methods defined in program.cs - BleepPic() and EndGame()
            
            //There are three ways to end game - user chooses to quit, 
            //bloop.energy > 200 and the bloop becomes twins!
            //or bloop.pokeCounter = 2 and the unhappy bloop is taken away"
            
            //INTRODUCTION

            BleepPic(); //this reusable method draws the Bloop the user has adopted

            Console.WriteLine("|================================================================|");
            Console.WriteLine("|    Congratulations on adopting a Bloop from the planet Bleep!  |");
            Console.WriteLine("|    Bloops are small and round and float like a balloon.        |");
            Console.WriteLine("|    When they are happy, they pulse with a pleasing color       |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|        Bloops are very easy to care for:                       |");
            Console.WriteLine("|        To feed your Bloop, take it outside in the moonlight.   |");
            Console.WriteLine("|        They get even more energetic when you juggle them.      |");
            Console.WriteLine("|        Most of all they love to sing!                          |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|================================================================|");
            Console.WriteLine();
            Console.WriteLine(" For best playing experience, please lengthen the console window.");
            Console.WriteLine();

            Console.WriteLine("Are you ready to begin?(yes/no)");
            string begin = Console.ReadLine().ToLower();

            while (begin != "yes")
            {
                Console.WriteLine("Are you ready to begin now?");
                begin = Console.ReadLine().ToLower();
            }


            //Main part of program

            Bleeps bloop = new Bleeps();
            bool keepPlaying = true;

            do
            {
                do
                {
                    //This pic and Menu shows each time
                    BleepPic();

                    Console.WriteLine();
                    Console.WriteLine("              Current status of {0} the Bloop:  ", bloop.BloopName);
                    Console.WriteLine("                        Energy: {0}             ", bloop.CurrentEnergy);
                    Console.WriteLine("                      isHappy?: {0}             ", bloop.IsHappy);
                    Console.WriteLine("                         Color: {0}             ", bloop.Color);
                    Console.WriteLine();
                    Console.WriteLine("|================================================================|");
                    Console.WriteLine("|               What would you like to do?                       |");
                    Console.WriteLine("|                  1) Go out in the moonlight                    |");
                    Console.WriteLine("|                  2) Juggle                                     |");
                    Console.WriteLine("|                  3) Sing                                       |");
                    Console.WriteLine("|                  4) Poke                                       |");
                    Console.WriteLine("|                  5) Quit                                       |");
                    Console.WriteLine("|================================================================|");
                    Console.WriteLine();

                    int choiceToDo = int.Parse(Console.ReadLine());
                    switch (choiceToDo)
                    {
                        case 1://Play in the moonlight
                            bloop.Energize();
                            break;
                        case 2:
                            bloop.Juggle();
                            break;
                        case 3:
                            bloop.Sing();
                            break;
                        case 4:
                            bloop.Poke();
                            break;
                        case 5:
                            EndGame();
                            keepPlaying = false;
                            break;
                        default:
                            Console.WriteLine("You are sitting. Nothing is happening. Ho hum.");
                            Console.WriteLine();
                            //for future - could lose energy here - would need to change get/set for bloop.currentEnergy
                            break;
                    }

                }

                while (keepPlaying == true && bloop.PokeCounter <= 2 && bloop.CurrentEnergy < 100);
                bloop.Color = "blue";//color changes with energy - could do this another way
            }
            while (keepPlaying == true && bloop.PokeCounter <= 2 && bloop.CurrentEnergy < 200);
            bloop.Color = "purple";//color changes with energy - could do this another way

            //Game ends with energy >=200
            if (bloop.CurrentEnergy>=200)
            {
                bloop.Color = "yellow";//color changes with energy - could do this another way

                Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                Console.WriteLine(" :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) ");
                Console.WriteLine();
                Console.WriteLine("               You have been an awesome owner! ");
                Console.WriteLine("           {0} is filled to the brim with {1} energy units...", bloop.BloopName, bloop.CurrentEnergy);
                Console.WriteLine("               and pulsing frantically with a {0} glow...", bloop.Color);
                Console.WriteLine("You watch in amazement as it wobbles and bobbles and splits in two...");
                Console.WriteLine("          You are now the proud owner of twin bleeps!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("|================================================================|");
                Console.WriteLine("|            ~~~~~~                      ~~~~~~                  |");
                Console.WriteLine("|         (O   oo    O)               (O   oo    O)              |");
                Console.WriteLine("|      (OO oo  --  oo OO)          (OO oo  --  oo OO)            |");
                Console.WriteLine("|      (OO oo  --  oo OO)          (OO oo  --  oo OO)            |");
                Console.WriteLine("|         (O   oo    O)               (O   oo    O)              |");
                Console.WriteLine("|            ~~~~~~                      ~~~~~~                  |");
                Console.WriteLine("|================================================================|");
                Console.WriteLine();

                Console.WriteLine("            What would you like to call your new Bloop?");
                Console.WriteLine();
                string babyBloopName = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("                Now {0} and {1} are tired.", bloop.BloopName, babyBloopName);
                Console.WriteLine("                     They are pulsing gently with a {0} glow.", bloop.Color);

                Console.WriteLine();
                Console.WriteLine("       You put the Bloops to bed and say nighty night.");
                Console.WriteLine("                Tomorrow is another day to play!");
                Console.WriteLine();
                Console.WriteLine(" :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) :) ");
                Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                
            }

            /////////// end of main here ///////////////////////
        }
        //NEW METHODS That can be called over and over again

        public static void BleepPic()
        {
            Console.WriteLine();          
            Console.WriteLine("|================================================================|");
            Console.WriteLine("|                             ~~~~~~                             |");
            Console.WriteLine("|                          (O   oo    O)                         |");
            Console.WriteLine("|                       (OO oo  --  oo OO)                       |");
            Console.WriteLine("|                       (OO oo  --  oo OO)                       |");
            Console.WriteLine("|                          (O   oo    O)                         |");
            Console.WriteLine("|                             ~~~~~~                             |");
            Console.WriteLine("|================================================================|");
            Console.WriteLine();
                       
        }

        public static void EndGame()
        {
            //Game ends if user chooses to end
            Console.WriteLine();
            Console.WriteLine("          You put the Bloop in its bed and say nighty night.");
            Console.WriteLine("                  Tomorrow is another day to play!");
            Console.WriteLine("");
            
        }
    }
}
