using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class Bleeps
    {
        //FIELDS (at least 3 required)

        private string bloopName; //name for the original Bloop
        private int currentNumBuds; //number of buds each Bleep currently has (every Bleep has exactly the same)
        private int currentEnergy; //amount of energy each Bleep currently has 
        private int energyToBud; //amount of energy needed to grow a new bud                      
        private bool isHappy; //becomes true if played with regularly.  
        private bool isAnnoyed; //if you annoy them, they'll Blick Bowl you

          

        //PROPERTIES  (at least 3 required)
        public string BloopName
        {
            get { return this.bloopName; }
            set { this.bloopName = value; }//allows user to choose a name
        }

       
        public int CurrentNumBuds
        {
            get { return this.currentNumBuds; }
            //no set because user does not have input into this
        }
        public int CurrentEnergy
        {
            get { return this.currentEnergy; }
            //no set because user does not have input into this
        }

        public int EnergyToBud
        {
            get { return this.energyToBud; }
            //no set because user does not have input into this
        }
        public bool IsHappy
        {
            get { return this.isHappy; }
            //no set because user does not have input into this
        }

        public bool IsAnnoyed
        {
            get { return this.isAnnoyed; }
            //no set because user does not have input into this
        }

        // CONSTRUCTORS (at least 1 required)
        public Bleeps()//default - no user input
        {
            this.bloopName = "Blobbi"; //default name
            this.currentNumBuds = 0;
            this.currentEnergy = 10;
            this.isHappy = true;
            this.isAnnoyed = false;

        }

        public Bleeps(string bloopName)//user chooses name for the Bloop
        {
            this.bloopName = bloopName; //user inputs a name
            this.currentNumBuds = 0;
            this.currentEnergy = 10;
            this.isHappy = false;
            this.isAnnoyed = false;

        }

        //METHODS (at least 3 required)

        public void Energize()
        {
            Console.WriteLine("Bleeps are energized by moonlight.");
            Console.WriteLine("This feels so good!");
            this.currentEnergy += 10;

        }

        public void Juggle()
        {
            Console.WriteLine("Bleeps love to play!  Juggling makes them happy and energetic!");
            this.currentEnergy += 10;
            this.isAnnoyed = false;
            this.isHappy = true;
        }

        public void Sing()
        {
            Console.WriteLine("Bleeps love singing best!");
            Console.WriteLine("You hear a faint humming in your head. It seems vaguely familiar...");
            Console.WriteLine("Boodee boodee boodee boop...");
                Console.WriteLine("......................Boodee boodee boodee boop");
            Console.WriteLine("Boodee boodee boodee boop...");
            Console.WriteLine(".........................Boop boop boop boop");
            this.currentEnergy += 50;
            this.isAnnoyed = false;
            this.isHappy = true;
        }

        public void Bud()
        {

        }

        public void Sleep()
        {

        }

        /////////// here there be dragons - don't delete these 2 curly brackets!
    }
}
