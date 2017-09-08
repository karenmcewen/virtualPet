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
            //Introduction 
            Console.WriteLine("Welcome to Planet PodLandia!");
            Console.WriteLine("Sadly, the planet's inhabitants, the Podi, have petered out.");
            Console.WriteLine("Only a single, sad and sickly podless Podus remains.");  
            
            //NTS-move this section to a separate thing that can be accessed again by typing 'help'
            Console.WriteLine("Your job is to nurture it back to health and repopulate PodLandia.");
            Console.WriteLine("Luckily, Podi reproduce by podicular parthenogenesis.");
            Console.WriteLine("A happy and healthy Podus produces podicular protuberances, or *Podulates*");
            Console.WriteLine("Once a particular number of protuberances (pods) appear, the Podus *Popates*,");
            Console.WriteLine("and each pod becomes a new Podus, or Pop.");
            Console.WriteLine("All the Pops will do exactly the same as the parent Podus");
            Console.WriteLine("and, in time, will popate themselves.");
            Console.WriteLine("If you take care of them, soon the planet will be repopulated!");
            //NTS-end moved section

            Console.WriteLine("Are you ready to begin?(yes/no)");

            string begin = Console.ReadLine().ToLower();

            while (begin != "yes")
            {
                Console.WriteLine("Are you ready to begin now?");
                begin = Console.ReadLine().ToLower();
            }

            //starting values
            //pod = tentacle; pop = offspring; Podus = individual entity; Podi = name of species collectively
            //original Podus and all poppys begin with 0 pods
            
            int numPops = 3; //number of offspring (pops) from a single popation
            int totalPops = 1; //total number of original plus all offspring and grand offspring and great-grand...etc.
            int popsToRePopulate = 100;//number of podi needed to repopulate the planet


            while (totalPops < popsToRePopulate)
            {
                //this is the main part of the program
                //Eat() to get energy, Play() to be happy
                //if energy (>=20), grows another pod (foot or tentacle)-->Podulate()
                //if isHappy (true) and numPods (=3) and energy (>=20) then creates offspring -->Popate()
            }
            //you win!

            Console.WriteLine("Congratulations! There are now {0} Podi. You have repopulated Planet Podlandia!", totalPops);

        /////////// here there be dragons - don't delete these 3 curly brackets!
    }
    }
}
