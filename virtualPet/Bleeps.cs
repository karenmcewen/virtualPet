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

        private string name;
        private int currentNumBuds; //number of buds each Bleep currently has (every Bleep has exactly the same)
        private int currentEnergy; //amount of energy each Bleep currently has 
        private int energyToBud; //amount of energy needed to grow a new bud                      
        private bool isHappy; //becomes true if played with regularly.  
        private bool isAnnoyed; //if you annoy them, they'll Blick Bowl you

          

        //PROPERTIES  (at least 3 required)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }//allows user to choose a name
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
            this.name = "Blobbi"; //default name
            this.currentNumBuds = 0;
            this.currentEnergy = 10;
            this.isHappy = true;
            this.isAnnoyed = false;

        }

        public Bleeps(string name)//user chooses name
        {
            this.name = name; //user inputs a name
            this.currentNumBuds = 0;
            this.currentEnergy = 10;
            this.isHappy = false;
            this.isAnnoyed = false;

        }

        //NTS THIS is an advanced option for later...
        public MiPodi(string name, int podiType)//user chooses name & type
        {
            this.name = name; //user inputs a name
            this.podiType = podiType; //user chooses a type
            this.currentNumPods = 0;
            this.currentEnergy = 10;
            this.isHappy = false;

        }

        //METHODS (at least 3 required)

        public void Eat()
        {

        }

        public void Play()
        {

        }

        public void Podulate()
        {

        }

        public void Popate()
        {

        }

        /////////// here there be dragons - don't delete these 2 curly brackets!
    }
}
