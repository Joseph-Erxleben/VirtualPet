﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }
        public bool IsOrganic { get; set; }

        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }


        public void SetName(string name)
        {
            Name = name;
            
        }

        public string GetName()
        {
            
            return Name;
        }

        public void SetSpecies(string species)
        {
            Species = species;

        }

        public string GetSpecies()
        {

            return Species;
        }

        public int GetHunger()
        {

            return Hunger;
        }
        public int GetBoredom()
        {

            return Boredom;
        }
        public int GetHealth()
        {

            return Health;
        }

        public void Feed()
        {
            Hunger -= 40;
        }

        public void Feed(string food)
        {
            switch (food)
            {
                case "fish":
                    Console.WriteLine(Name + " loves fish!");
                    Hunger -= 50;
                    break;
                case "mice":
                    Console.WriteLine(Name + " likes mice.");
                    Hunger -= 45;
                    break;
                case "hot dog":
                    Console.WriteLine(Name + " kind of likes hot dogs.");
                    Hunger -= 40;
                    break;
                case "poison":
                    Console.WriteLine(Name + " does not like poison :(");
                    Hunger -= 5;
                    Health -= 50;
                    break;
                default:
                    Hunger -= 40;
                    break;
            }
            
        }

        public void SeeDoctor()
        {
            Health += 30;
        }

        public virtual void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }

        public virtual void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }

        public virtual void GiveOil()
        {

        }

        public virtual void PerformMaintenance()
        {

        }

        public int Oil { get; set; }
        public int Performance { get; set; }
    }
}
