using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robotic : Pet
    {
        public int Oil { get; set; } = 100;
        public int Performance { get; set; } = 100;

        public void GiveOil()
        {
            Oil += 15;
        }

        public void PerformMaintenance()
        {
            Performance += 15;
        }

        public override void Tick()
        {
            Oil -= 5;
            Performance -= 5;
            Boredom += 5;
            
        }
    }
}
