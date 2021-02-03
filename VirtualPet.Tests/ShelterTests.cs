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

    }
}
