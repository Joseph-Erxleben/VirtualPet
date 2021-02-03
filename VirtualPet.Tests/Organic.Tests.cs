using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicTests
    {
        private Organic testOrganic;

        public OrganicTests()
        {
            testOrganic = new Organic();
        }


        [Fact]
        public void Organic_Class_Inherits_Health()
        {
            int health = testOrganic.Health;


            Assert.Equal(testOrganic.Health, health);
        }


        [Fact]
        public void Organic_Class_Inherits_Hunger()
        {
            int hunger = testOrganic.Hunger;


            Assert.Equal(testOrganic.Hunger, hunger);
        }


        [Fact]
        public void Organic_Class_Inherits_Boredom()
        {
            int boredom = testOrganic.Boredom;


            Assert.Equal(testOrganic.Boredom, boredom);
        }

        [Fact]
        public void New_Organic_Class_Sets_Hunger_To_50()
        {
            Assert.Equal(50, testOrganic.Hunger);
        }

        [Fact]
        public void Feed_Should_Decrease_Hunger_By_40()
        {
            testOrganic.Feed();

            Assert.Equal(10, testOrganic.GetHunger());
        }
    }
}
