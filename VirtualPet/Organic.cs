using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Organic : Pet
    {
        
        public Organic(string name, string species)
        {
            Name = name;
            Species = species;
            IsOrganic = true;
        }
    }

    
}
