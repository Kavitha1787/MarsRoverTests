using System;

//Mission Object:
//Rover position and Location where (x,y,Z ) where Z in (N,E,S,W)
//Grid of positions,where (0 0 N)Rover starts at 0 0 facing North
//Message sent in commands :L R M
//1.Plateo Size (5 5)
//2.Array of Rover Objects contains
//a.Rover's position(first Line) 
//b.Rover commands ( 2 nd Line)
//MarsRoverTests 1 and Rover 2 has 2 lines of input ( 1 2 N) and (3 3 E)
//3.Rover should spin left
//4.Rover should spin right
//5.Rover should move forward
//MarsRoverTests 2 should go to 1 3 N and 5 1 N
//When_North_And_Turn_Left_Direction_Should_Be_West()
// When_North_And_Turn_Right_Direction_Should_Be_East()

namespace MarsRoverTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}









//int.parse convert only string to int cannot convert null values
//convert.ToInt32 can convert any data type values to Int
//if we want to return more than 1 value have to use out