using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robotic : Pet
    {

        public Robotic()
        {

        }
        public Robotic(string name, string species)
        {
            Name = name;
            Species = species;
            IsOrganic = false;
            Oil = 50;
            Performance = 100;
        }

        public override void GiveOil()
        {
            Oil += 25;
        }

        public override void PerformMaintenance()
        {
            Oil += 10;
            Performance += 40;
        }

        public override void Tick()
        {
            Oil -= 5;
            Performance -= 5;
            Boredom += 5;
            
        }
        public override void Play()
        {
            Oil -= 15;
            Performance -= 15;
            Boredom -= 35;
        }
    }
}
