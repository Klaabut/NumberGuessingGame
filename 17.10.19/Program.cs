using System;

namespace _17._10._19
{
    class Program
    {
        static void Main(string[] args)
        {

            //TASK 1

            /*int i = 1;
            int jaguvad = 0;
            while (i <= 100)
            {
                
                int j = i % 3;
                if (j >= 1)
                {
                    Console.WriteLine($"{i} ei jagu 3-ga. ");


                }
                else
                {
                    Console.WriteLine($"{i} jagub 3-ga");
                    jaguvad++;

                }
                  i++;  
            }
            Console.WriteLine($"{jaguvad} arvu jaguvad 3-ga");
            



                Console.ReadLine();*/







            //TASK 2
                Start:
                Random randomGenerator = new Random();
                int lampNr = randomGenerator.Next(1, 10);
            bool youWon = false;
            int guess = 0;
            int answer;
            while (guess <= 3 || youWon == true)
            {
                
                Console.WriteLine("INSERT A NUMBER FROM 1 TO 10, IF YOU GUESS THE SAME NUMBER AS THE AI YOU WIN.");
                Start1:
                int userNr;
                userNr = int.Parse(Console.ReadLine());


                if (userNr < 1 || 10 < userNr)
                {
                    Console.WriteLine("Write a correct number.");
                    goto Start1;
                }
                
               
                
           
                if (lampNr == userNr)
                {
                    Console.WriteLine("YOU WON, CONGRATS!!!");
                    youWon = true;
                    Console.WriteLine("Want to play again? type  1 if yes and 2 if no.");
                    answer = int.Parse(Console.ReadLine());
                    if (answer == 1)
                    {
                        goto Start;
                    }
                    else
                    {
                     break;
                    }
                   
                }
                else
                {
                    if (guess < 3)
                    {
                        Console.WriteLine($"WRONG!!! TRY AGAIN, YOU ARE ON TRY {guess + 1}");

                        guess++;
                    }
                    else
                    {
                        Console.WriteLine($"WRONG!!! This was your last try. :( The number was {lampNr}. Better luck next time.");

                        Console.WriteLine("Want to play again? type  1 if yes and 2 if no.");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            goto Start;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                

                
            }

                


            Console.ReadLine();

        }
    }
}
