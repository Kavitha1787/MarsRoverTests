using MarsRoverTest;
using Xunit;
using System;

namespace MarsRover
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            //define Rover object
            //arrange
            RoverTest rover = new RoverTest("1 2 S");
            //act we want to use this Rover Objs
            rover.SpinLeft();
            //Assert
            // Assert.True(rover.direction == "W");
            Console.WriteLine(rover.direction);
            Assert.Equal("E", rover.direction);

        }

        [Fact]
        public void SpinRight()
        {

            RoverTest rover = new RoverTest("1 2 N");
            rover.SpinRight();
            Console.WriteLine(rover.direction);
            Assert.Equal("E", rover.direction);

        }
        [Fact]
        public void StepForward()
        {

            RoverTest rover = new RoverTest("1 2 S");
            rover.StepForward();
            Console.WriteLine(rover.direction);
            Assert.Equal(1, rover.y);

        }
        [Fact] //Test Method
        public void Move()
        {
            //rover 1 sample test case //arrange
            RoverTest rover = new RoverTest("1 2 N");
            //act
            rover.Move("LMLMLMLMM");

            // assert
           
           Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);

            //rover 2 sample test case
            rover = new RoverTest("3 3 E");
            //Print
            
            rover.Move("MMRMMRMRRM");
            // Console.WriteLine(rover.x + " " + rover.y + " " + rover.direction);
            // assert
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}


