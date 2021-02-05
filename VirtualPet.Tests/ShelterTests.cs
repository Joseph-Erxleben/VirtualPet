using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        Shelter testShelter;

        public ShelterTests()
        {
            testShelter = new Shelter();
        }

        Pet newPet = new Pet();
        [Fact]
        public void Shelter_Should_Have_Name()
        {
            testShelter.Name = "shelter";
            Assert.Equal("shelter", testShelter.Name);
        }

        [Fact]
        public void SetName_Should_Assign_Name_Property()
        {
            testShelter.SetName("jasmine");
            Assert.Equal("jasmine", testShelter.Name);
        }

        [Fact]
        public void ListofPets_Should_Return_1_Element()
        {
            testShelter.ListofPets.Add(newPet);
            Assert.Single(testShelter.ListofPets);
        }

        [Fact]

        public void AddPet_Should_Increase_ListofPets_by_1()
        {
            testShelter.AddPet(newPet);
            Assert.Single(testShelter.ListofPets);
        }

        [Fact]
        public void RemovePet_Should_Decrease_ListofPets_by_1()
        {
            testShelter.AddPet(newPet);
            testShelter.AddPet(newPet);

            testShelter.RemovePet(0);
            Assert.Single(testShelter.ListofPets);
            
        }

    }
}
