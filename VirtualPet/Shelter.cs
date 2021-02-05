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

      public Pet Pet = new Pet();
       
      public void AddPet(Pet pet)
        {
            ListofPets.Add(pet);
        }

      public void RemovePet(int index)
        {
            ListofPets.RemoveAt(index);
        }

        public int SelectPet(string userPet)
        {
            int petIndex = -1;

            for (int i = 0; i < ListofPets.Count; i++)
            {
                string petInList = ListofPets[i].Name;

                if (userPet == petInList)
                {
                    Console.WriteLine(petInList + " has been adopted");
                    petIndex = i;
                }
            }

            return petIndex;

        }

        public void Tick()
        {
            for (int i = 0; i < ListofPets.Count; i++)
            {
                Pet.Tick();
            }
        }
    } 
}