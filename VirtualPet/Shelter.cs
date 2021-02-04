using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public string Name { get; set; } = "the";

        public void SetName(string name)
        {
            Name = name;
        }

        
      public List<Pet> ListofPets = new List<Pet>();
       
      public void AddPet(Pet pet)
        {
            ListofPets.Add(pet);
        }

      public void RemovePet(Pet pet)
        {
            ListofPets.Remove(pet);
        }
    } 
}