using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class Bleeps
    {
        //FIELDS (+at least 3 required)
        //5 fields - bloopName, color, currentEnergy, pokeCounter,isHappy

        private string bloopName; //name for the original Bloop
        private string color;//Bleeps change color when happy and energized
        private int currentEnergy; //amount of energy each Bleep currently has   
        private int pokeCounter; //how many times user pokes the Bleep        
        private bool isHappy; //becomes true if played with regularly.  


        //FOR LATER DEVELOPMENT
        //private bool isAnnoyed; //if you annoy them, they'll Blick Bowl you
        // private int currentNumBuds; //number of buds each Bleep currently has (every Bleep has exactly the same)  
        //private int energyToBud; //amount of energy needed to grow a new bud       

        //PROPERTIES  (+at least 3 required)
        //5 properties - BloopName, Color, CurrentEnergy, PokeCounter,IsHappy
        public string BloopName
        {
            get { return this.bloopName; }
            set { this.bloopName = value; }//needed if want to change name in Program Main
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }//needed if want to change name in Program Main
        }

        public int CurrentEnergy
        {
            get { return this.currentEnergy; }
            //no set because user does not have input into this
        }
        public int PokeCounter
        {
            get { return this.pokeCounter; }
            //no set because user does not have input into this
        }

        public bool IsHappy
        {
            get { return this.isHappy; }
            //no set because user does not have input into this
        }

        /* FOR LATER DEVELOPMENT
        public int CurrentNumBuds
        {
            get { return this.currentNumBuds; }
            //no set because user does not have input into this
        }
        public bool IsAnnoyed
        {
            get { return this.isAnnoyed; }
            //no set because user does not have input into this
        }
        public int EnergyToBud
        {
            get { return this.energyToBud; }
            //no set because user does not have input into this
        }
        */

        // CONSTRUCTORS (+at least 1 required)
        public Bleeps()//default - no user input
        {
            this.bloopName = "Blobbi"; //default name
            this.color = "green";//beginning color
            this.currentEnergy = 10;
            this.isHappy = true;
            this.pokeCounter = 0;
            //this.isAnnoyed = false;
            //this.currentNumBuds = 0;
        }

        public Bleeps(string bloopName)//user chooses name for the Bloop - not used in MVP version
        {
            this.bloopName = bloopName; //user inputs a name
            this.color = "blue";//beginning color
            this.currentEnergy = 10;
            this.isHappy = false;
            this.pokeCounter = 0;
            //this.isAnnoyed = false;
            //this.currentNumBuds = 0;

        }

        //METHODS (+at least 3 required)
        //4 methods - Energize(), Juggle(), Sing(), Poke()
        public void Energize()
        {
            Console.WriteLine();
            Console.WriteLine("* ~ * ~ * ~ * Bleeps are energized by moonlight. * ~ * ~ * ~ * ");
            Console.WriteLine("* ~ * ~ * ~ *         This feels so good!        * ~ * ~ * ~ * ");
            Console.WriteLine();
            this.currentEnergy += 10;
            this.isHappy = true;
        }

        public void Juggle()
        {
            Console.WriteLine();
            Console.WriteLine("!  !  !  !  !          Bleeps love to play!       !  !  !  !  ! ");
            Console.WriteLine("!  !  !  Juggling makes them happy and more energetic!  !  !  !");
            Console.WriteLine();
            this.currentEnergy += 20;
            this.isHappy = true;
        }

        public void Sing()
        {
            Console.WriteLine();
            Console.WriteLine("                     Bleeps love singing best!");
            Console.WriteLine("                You hear a faint humming in your head. ");
            Console.WriteLine("                     It seems vaguely familiar...");
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine("     Boodee boodee boodee boop");
                Console.WriteLine("                                      Boodee boodee boodee boop");
                Console.WriteLine("     Boodee boodee boodee boop");
                Console.WriteLine("                                       Boop boop boop boop");
                Console.WriteLine();
            }
            Console.WriteLine("     Boodee boodee boodee boop");
            Console.WriteLine("                                       Boodee boodee boodee boop");
            Console.WriteLine("     Boodee boodee boodee boop");
            Console.WriteLine("                                          Boodee boodee boop!");
            Console.WriteLine();

            this.currentEnergy += 50;
            this.isHappy = true;
        }

        public void Poke()
        {
            Console.WriteLine();
            Console.WriteLine("x x x x x x x x Bleeps do not like to be poked.  x x x x x x x x ");
            switch (pokeCounter)
            {
                case 0:
                    Console.WriteLine("x x x x x x x x         Please be polite.        x x x x x x x x ");
                    break;
                case 1:
                    Console.WriteLine("x x x x x x x   You are not being a nice person. x x x x x x x x ");
                    break;
                case 2:
                    Console.WriteLine("x x x x x x x       A representative from the      x x x x x x x");
                    Console.WriteLine("x x x x x   Society for Prevention of Bloop Cruelty    x x x x x");
                    Console.WriteLine("x x x          has arrived to take your Bloop away.        x x x");
                    Console.WriteLine("x x x                      Goodbye. :(                     x x x");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
            }
            this.isHappy = false;
            pokeCounter += 1;

        }


    }
}
