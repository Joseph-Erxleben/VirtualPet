using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robotic : Pet
    {
        public int Oil { get; set; } = 50;
        public int Performance { get; set; } = 100;

        public Robotic()
        {

        }
        public Robotic(string name, string species)
        {
            Name = name;
            Species = species;
            IsOrganic = false;
        }

        public void GiveOil()
        {
            Oil += 25;
        }

        public void PerformMaintenance()
        {
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
