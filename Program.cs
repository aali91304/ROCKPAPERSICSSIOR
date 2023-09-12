using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
          
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;


                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose between ROCK , PAPER and SCISSOR:     ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rmd = new Random();

                    randomInt = rmd.Next(1, 4);


                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer choose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW !! \n\n");

                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player WINS!! \n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSOR")
                            {
                                Console.WriteLine("CPU WINS!! \n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine(" DRAW!! \n\n");

                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player WINS!! \n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSOR")
                            {
                                Console.WriteLine("CPU WINS!! \n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSOR";
                            Console.WriteLine("Computer choose SCISSOR");
                            if (inputPlayer == "SCISSOR")
                            {
                                Console.WriteLine("DRAW !! \n\n");

                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player WINS!! \n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!! \n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry:");

                            break;
                    }

                    Console.WriteLine("\n\n Scores: \tPlayer:\t{0}\t CPU: \t{1}",scorePlayer,scoreCPU);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON !! ");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!! ");
                }
                else
                {

                }
                Console.WriteLine("Do you Want to playAgain ?(y/n)");
                string loop = Console.ReadLine();
                if(loop == "y")
                {
                    playAgain= true;
                    Console.Clear();
                }
                else if(loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
                

            }
        }
    }
}
