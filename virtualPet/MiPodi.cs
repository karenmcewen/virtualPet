using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class MiPodi
    {
        //FIELDS

        private string name;
        private string color;
        private int numPods;
        private int currentEnergy;
        private bool isHappy;

        //PROPERTIES
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int NumPods
        {
            get { return this.numPods; }
        }
        public int CurrentEnergy
        {
            get { return this.currentEnergy; }
        }

        public bool IsHappy
        {
            get { return this.isHappy; }
        }

        // CONSTRUCTORS
        public MiPodi()
        {
            this.name = "Midgie";
            this.color = "red";
            this.numPods = 1;
            this.currentEnergy = 10;
            this.isHappy = true;
            
        }

        public MiPodi(string name)
        {
            this.name = "Midgie";
            this.color = "red";
            this.numPods = 1;
            this.currentEnergy = 10;
            this.isHappy = true;

        }
        /////////// 
    }
}
