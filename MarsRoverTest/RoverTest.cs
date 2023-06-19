using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverTest
{
    public class RoverTest
    {
        public int x; //X cord of the Rover
        public int y;//Y cord of the Rover
        public string direction;//current direction which rover facing

        //Extracts the values from location into x, y, direction //location = " 1 2 N" ,wil take as string value which is in double quotes
        public RoverTest(string location)//Split that location parameter delimeter with spaces,if we want to return more than 1 value have to use out,covertthe string into integer and retrun int value
        {
            Int32.TryParse(location.Split(" ")[0], out x); //first index position
            Int32.TryParse(location.Split(" ")[1], out y); //2 nd index position
            direction = location.Split(" ")[2];//String is not an int
        }
        public void SpinLeft()
        {
            //throws SYstem not implemented exception if not implemented
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();


            }
        }

        public void SpinRight()
        {
            //throw new NotImplementedException();
            //SYstem not implemented exception if not implemented
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void StepForward()
        {
            //throw new NotImplementedException();
            //SYstem not implemented exception if not implemented
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void Move(string roverCommand) //LMLMLMLMM or MMRMMRMRRM
        {
            char[] instructions = roverCommand.ToCharArray();//create to rovercommand
                                                             //loop through  array.For each letter,call SPinLeft,call SPinRight,call StepForward

            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;

                    default:
                        throw new ArgumentException();



                }
            }



        }
    }
}


    

    
