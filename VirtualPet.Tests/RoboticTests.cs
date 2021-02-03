using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RoboticTests
    {
        Robotic testRobotic;

        public RoboticTests()
        {
            testRobotic = new Robotic();
        }



        [Fact]
        public void Check_Oil_Is_50()
        {
            Assert.Equal(50, testRobotic.Oil);
        }

        [Fact]
        public void Check_Performance_Is_100()
        {
            Assert.Equal(100, testRobotic.Performance);
        }

        [Fact]
        public void Give_Oil_Should_Increase_Oil_By_25()
        {
            testRobotic.Oil = 0;

            testRobotic.GiveOil();

            Assert.Equal(25, testRobotic.Oil);
        }

        [Fact]
        public void PerformMaintenance_Should_Increase_Performance_By_40()
        {
            testRobotic.Performance = 0;

            testRobotic.PerformMaintenance();

            Assert.Equal(40, testRobotic.Performance);
        }

        [Fact]
        public void Tick_Should_Update_Oil()
        {
            testRobotic.Oil = 0;

            testRobotic.Tick();

            Assert.Equal(-5, testRobotic.Oil);
        }

        [Fact]
        public void Tick_Should_Update_Performance()
        {
            testRobotic.Performance = 0;

            testRobotic.Tick();

            Assert.Equal(-5, testRobotic.Performance);
        }

        [Fact]
        public void Tick_Should_Update_Boredom()
        {
            testRobotic.Boredom = 0;

            testRobotic.Tick();

            Assert.Equal(5, testRobotic.Boredom);
        }

        [Fact]

        public void Play_Should_Update_Performance()
        {
            testRobotic.Performance = 100;
            testRobotic.Play();
            Assert.Equal(85, testRobotic.Performance);
        }

        [Fact]
        public void Play_Should_Update_Boredom()
        {
            testRobotic.Boredom = 100;
            testRobotic.Play();
            Assert.Equal(65, testRobotic.Boredom);
        }

        [Fact]
        public void Play_Should_Update_Oil()
        {
            testRobotic.Oil = 100;
            testRobotic.Play();
            Assert.Equal(85, testRobotic.Oil);
        }
    }
}
