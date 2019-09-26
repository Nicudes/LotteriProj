using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotteriprojekt
{
  public class Game
    {
        public void newGame()
        {
           
            int pCash;
            int cpuCash;
            int bet;
            int guess;

            bool gameOver = false;
            string name;


            Console.WriteLine("Welcome to the 50/50 game, this is your chance to win against the CPU and earn alot of money...or lose them all");
            Console.WriteLine("What is your name?");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Hello {0} how much would you like to deposit into the game?", name);
            pCash = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total cash deposited: {0}", pCash);

            while (pCash <= 0)
            {
                Console.WriteLine("Please deposit more than 0!");
                Console.WriteLine("Hello {0} how much would you like to deposit into the game?", name);
                pCash = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total cash deposited: {0}", pCash);

            }


            cpuCash = pCash;

            while (gameOver == false)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("New game initiated!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("How much do you want to bet?");

                bet = Convert.ToInt32(Console.ReadLine());

                //Variabler för random
                Random random = new Random();
                int randomNr = random.Next(1, 3);
                int cpuGuess = random.Next(1, 3);

                while (bet > pCash)
                    {
                        Console.WriteLine("Bet is higher than your balance, please try again");
                    Console.WriteLine("How much do you want to bet?");
                    bet = Convert.ToInt32(Console.ReadLine());
                  
                }
                while (bet <= 0)
                {
                    Console.WriteLine("Bet must be higher than 0!");
                    Console.WriteLine("How much do you want to bet?");
                    bet = Convert.ToInt32(Console.ReadLine());
                }
                while (bet > cpuCash)
                {
                    Console.WriteLine("Computer cash is lower than the bet value. Please enter a at or bellow: " + cpuCash);


                }



                Console.WriteLine("Your bet is: " + bet + " Your total balance: " + (pCash - bet) );
                pCash = pCash - bet;
                Console.WriteLine("..................................................................");
                Console.WriteLine("The CPU bet is: " + bet + " CPU total balance: " + (cpuCash - bet) );
                cpuCash = cpuCash - bet;
                Console.WriteLine("..................................................................");
                Console.WriteLine("Pick RED or BLACK ");
                Console.WriteLine("_________________        ___________________");
                Console.WriteLine("|PRESS 1 for RED|        |PRESS 2 for BLACK|");
                Console.WriteLine("|_______________|        |_________________|");
                guess = Convert.ToInt32(Console.ReadLine());

                //Spelare och CPU vinner
                if (guess == randomNr && cpuGuess == randomNr)
                {
                    if (randomNr == 1)
                    {
                        Console.ForegroundColor
                         = ConsoleColor.Red;

                        Console.WriteLine("--------------------RESULTS-----------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("-----oooooo--------oooooooo---oooo----------");
                        Console.WriteLine("-----oooooooo------oooooooo---oooooo--------");
                        Console.WriteLine("-----ooo---ooo-----ooo--------ooo-ooo-------");
                        Console.WriteLine("-----oooooooo------ooooooo----ooo---ooo-----");
                        Console.WriteLine("-----ooo---ooo-----ooo--------ooo--ooo------");
                        Console.WriteLine("-----ooo----ooo----oooooooo---ooo-ooo-------");
                        Console.WriteLine("-----ooo-----ooo---oooooooo---oooo----------");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------RESULTS-----------------");
                        Console.ResetColor();
                    
                        
                    }
                    else if (randomNr == 2)
                    {

                        Console.ForegroundColor
                           = ConsoleColor.DarkGray;

                        Console.WriteLine("--------------------------------RESULTS-----------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("-----oooooooo-----ooo-----------oooooo----------ooooooo---ooo-----ooo-----");
                        Console.WriteLine("-----ooooooooo----ooo----------oooooooo-------ooooooooo---ooo----ooo------");
                        Console.WriteLine("-----ooo---ooo----ooo---------ooo----ooo-----ooo----------ooo--ooo--------");
                        Console.WriteLine("-----oooooooo-----ooo---------ooo----ooo----ooo-----------oooooo----------");
                        Console.WriteLine("-----ooo---ooo----ooo--------oooooooooooo---ooo-----------ooooo-----------");
                        Console.WriteLine("-----ooooooooo----oooooooo---ooo------ooo---ooooooooooo---ooo--ooo--------");
                        Console.WriteLine("-----ooooooo------oooooooo---ooo------ooo-----ooooooooo---ooo----ooo------");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------RESULTS-----------------------------------");
                        Console.ResetColor();


                    }
                    Console.WriteLine(".................................................................................");
                    Console.WriteLine("YOU WIN!");
                    pCash = pCash + (bet *2);
                    cpuCash = cpuCash + (bet * 2);
                    Console.WriteLine("Your current balance is: {0}", pCash );
                    Console.WriteLine(".................................................................................");
                    Console.WriteLine("CPU WON! ");
                    Console.WriteLine("CPU current balance is: {0}", cpuCash);
                    Console.WriteLine(".................................................................................");

                    if (pCash < 1)
                    {
                        Console.WriteLine("SUFFICIENT FUNDS, YOU LOST... \n GAME OVER! \n \n GETTING KICKED OUT OF THE GAME...PRESS A KEY TO ACCEPT YOUR FATE");
                        Console.ReadKey();
                        gameOver = true;

                    }
                    if (cpuCash < 1)
                    {
                        Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                        Console.WriteLine("Your total balance after winning against the CPU {0}", pCash);
                        gameOver = true;
                    }
                    if (pCash < 1 && cpuCash < 1)
                    {
                        Console.WriteLine("BOTH LOST!!!");
                        Console.WriteLine("BOTH KICKED OUT OF THE GAME! Player ended up on: {0} CPU ended up on: {1}", pCash, cpuCash);
                        gameOver = true;
                    }

                }


                //Spelare och CPU förlorar
                else if (guess != randomNr && cpuGuess != randomNr)
                {
                    if (randomNr == 1)
                    {
                        Console.ForegroundColor
                         = ConsoleColor.Red;

                        Console.WriteLine("--------------------RESULTS-----------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("-----oooooo--------oooooooo---oooo----------");
                        Console.WriteLine("-----oooooooo------oooooooo---oooooo--------");
                        Console.WriteLine("-----ooo---ooo-----ooo--------ooo-ooo-------");
                        Console.WriteLine("-----oooooooo------ooooooo----ooo---ooo-----");
                        Console.WriteLine("-----ooo---ooo-----ooo--------ooo--ooo------");
                        Console.WriteLine("-----ooo----ooo----oooooooo---ooo-ooo-------");
                        Console.WriteLine("-----ooo-----ooo---oooooooo---oooo----------");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------RESULTS-----------------");
                        Console.ResetColor();


                    }
                    else if (randomNr == 2)
                    {

                        Console.ForegroundColor
                           = ConsoleColor.DarkGray;

                        Console.WriteLine("--------------------------------RESULTS-----------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("-----oooooooo-----ooo-----------oooooo----------ooooooo---ooo-----ooo-----");
                        Console.WriteLine("-----ooooooooo----ooo----------oooooooo-------ooooooooo---ooo----ooo------");
                        Console.WriteLine("-----ooo---ooo----ooo---------ooo----ooo-----ooo----------ooo--ooo--------");
                        Console.WriteLine("-----oooooooo-----ooo---------ooo----ooo----ooo-----------oooooo----------");
                        Console.WriteLine("-----ooo---ooo----ooo--------oooooooooooo---ooo-----------ooooo-----------");
                        Console.WriteLine("-----ooooooooo----oooooooo---ooo------ooo---ooooooooooo---ooo--ooo--------");
                        Console.WriteLine("-----ooooooo------oooooooo---ooo------ooo-----ooooooooo---ooo----ooo------");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------RESULTS-----------------------------------");
                        Console.ResetColor();


                    }
                    Console.WriteLine(".................................................................................");
                    Console.WriteLine("YOU LOST!");
                    Console.WriteLine("Your current balance is: {0}", pCash);
                    Console.WriteLine(".................................................................................");
                    Console.WriteLine("CPU LOST! ");
                    Console.WriteLine("CPU current balance is: {0}", cpuCash);
                    Console.WriteLine(".................................................................................");


                    if (pCash < 1)
                    {
                        Console.WriteLine("SUFFICIENT FUNDS, YOU LOST... \n GAME OVER! \n \n GETTING KICKED OUT OF THE GAME...PRESS A KEY TO ACCEPT YOUR FATE");
                        Console.ReadKey();
                        gameOver = true;

                    }
                    if (cpuCash < 1)
                    {
                        Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                        Console.WriteLine("Your total balance after winning against the CPU {0}", pCash);
                        gameOver = true;
                    }
                    if (pCash < 1 && cpuCash < 1)
                    {
                        Console.WriteLine("BOTH LOST!!!");
                        Console.WriteLine("BOTH KICKED OUT OF THE GAME! Player ended up on: {0} CPU ended up on: {1}", pCash, cpuCash);
                        gameOver = true;
                    }



                }


                //Spelare förlorar och CPU vinner
                else if (guess != randomNr && cpuGuess == randomNr)
                {
                    if (randomNr == 1)
                    {
                        Console.ForegroundColor
                         = ConsoleColor.Red;

                        Console.WriteLine("--------------------RESULTS-----------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("-----oooooo--------oooooooo---oooo----------");
                        Console.WriteLine("-----oooooooo------oooooooo---oooooo--------");
                        Console.WriteLine("-----ooo---ooo-----ooo--------ooo-ooo-------");
                        Console.WriteLine("-----oooooooo------ooooooo----ooo---ooo-----");
                        Console.WriteLine("-----ooo---ooo-----ooo--------ooo--ooo------");
                        Console.WriteLine("-----ooo----ooo----oooooooo---ooo-ooo-------");
                        Console.WriteLine("-----ooo-----ooo---oooooooo---oooo----------");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------RESULTS-----------------");
                        Console.ResetColor();


                    }
                    else if (randomNr == 2)
                    {

                        Console.ForegroundColor
                           = ConsoleColor.DarkGray;

                        Console.WriteLine("--------------------------------RESULTS-----------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("-----oooooooo-----ooo-----------oooooo----------ooooooo---ooo-----ooo-----");
                        Console.WriteLine("-----ooooooooo----ooo----------oooooooo-------ooooooooo---ooo----ooo------");
                        Console.WriteLine("-----ooo---ooo----ooo---------ooo----ooo-----ooo----------ooo--ooo--------");
                        Console.WriteLine("-----oooooooo-----ooo---------ooo----ooo----ooo-----------oooooo----------");
                        Console.WriteLine("-----ooo---ooo----ooo--------oooooooooooo---ooo-----------ooooo-----------");
                        Console.WriteLine("-----ooooooooo----oooooooo---ooo------ooo---ooooooooooo---ooo--ooo--------");
                        Console.WriteLine("-----ooooooo------oooooooo---ooo------ooo-----ooooooooo---ooo----ooo------");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------RESULTS-----------------------------------");
                        Console.ResetColor();


                    }
                    Console.WriteLine(".................................................................................");
                    Console.WriteLine("YOU LOST!");
                    cpuCash = cpuCash + (bet * 2);
                    Console.WriteLine("Your current balance is: {0}", pCash);
                    Console.WriteLine(".................................................................................");
                    Console.WriteLine("CPU WON! ");
                    Console.WriteLine("CPU current balance is: {0}", cpuCash);
                    Console.WriteLine(".................................................................................");


                    if (pCash < 1)
                    {
                        Console.WriteLine("SUFFICIENT FUNDS, YOU LOST... \n GAME OVER! \n \n GETTING KICKED OUT OF THE GAME...PRESS A KEY TO ACCEPT YOUR FATE");
                        Console.ReadKey();
                        gameOver = true;

                    }
                    if (cpuCash < 1)
                    {
                        Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                        Console.WriteLine("Your total balance after winning against the CPU {0}", pCash);
                        gameOver = true;
                    }
                    if (pCash < 1 && cpuCash < 1)
                    {
                        Console.WriteLine("BOTH LOST!!!");
                        Console.WriteLine("BOTH KICKED OUT OF THE GAME! Player ended up on: {0} CPU ended up on: {1}", pCash, cpuCash);
                        gameOver = true;
                    }



                }

                //Spelare vinner och CPU förlorar
                else if (guess == randomNr && cpuGuess != randomNr)
                {
                    if (randomNr == 1)
                    {
                        Console.ForegroundColor
                         = ConsoleColor.Red;

                        Console.WriteLine("--------------------RESULTS-----------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("-----oooooo--------oooooooo---oooo----------");
                        Console.WriteLine("-----oooooooo------oooooooo---oooooo--------");
                        Console.WriteLine("-----ooo---ooo-----ooo--------ooo-ooo-------");
                        Console.WriteLine("-----oooooooo------ooooooo----ooo---ooo-----");
                        Console.WriteLine("-----ooo---ooo-----ooo--------ooo--ooo------");
                        Console.WriteLine("-----ooo----ooo----oooooooo---ooo-ooo-------");
                        Console.WriteLine("-----ooo-----ooo---oooooooo---oooo----------");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------RESULTS-----------------");
                        Console.ResetColor();


                    }
                    else if (randomNr == 2)
                    {

                        Console.ForegroundColor
                           = ConsoleColor.DarkGray;

                        Console.WriteLine("--------------------------------RESULTS-----------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("-----oooooooo-----ooo-----------oooooo----------ooooooo---ooo-----ooo-----");
                        Console.WriteLine("-----ooooooooo----ooo----------oooooooo-------ooooooooo---ooo----ooo------");
                        Console.WriteLine("-----ooo---ooo----ooo---------ooo----ooo-----ooo----------ooo--ooo--------");
                        Console.WriteLine("-----oooooooo-----ooo---------ooo----ooo----ooo-----------oooooo----------");
                        Console.WriteLine("-----ooo---ooo----ooo--------oooooooooooo---ooo-----------ooooo-----------");
                        Console.WriteLine("-----ooooooooo----oooooooo---ooo------ooo---ooooooooooo---ooo--ooo--------");
                        Console.WriteLine("-----ooooooo------oooooooo---ooo------ooo-----ooooooooo---ooo----ooo------");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("\n");
                        Console.WriteLine("--------------------------------RESULTS-----------------------------------");
                        Console.ResetColor();


                    }
                    Console.WriteLine(".................................................................................");
                    Console.WriteLine("YOU WIN!");
                    pCash = pCash + (bet * 2);
  
                    Console.WriteLine("Your current balance is: {0}", pCash);
                    Console.WriteLine(".................................................................................");
                    Console.WriteLine("CPU LOST! ");
                    Console.WriteLine("CPU current balance is: {0}", cpuCash);
                    Console.WriteLine(".................................................................................");


                    if (pCash < 1)
                    {
                        Console.WriteLine("SUFFICIENT FUNDS, YOU LOST... \n GAME OVER! \n \n GETTING KICKED OUT OF THE GAME...PRESS A KEY TO ACCEPT YOUR FATE");
                        Console.ReadKey();
                        gameOver = true;

                    }
                    if (cpuCash < 1)
                    {
                        Console.WriteLine("WINNER WINNER CHICKEN DINNER!");
                        Console.WriteLine("Your total balance after winning against the CPU {0}", pCash);
                        gameOver = true;
                    }
                    if (pCash < 1 && cpuCash < 1)
                    {
                        Console.WriteLine("BOTH LOST!!!");
                        Console.WriteLine("BOTH KICKED OUT OF THE GAME! Player ended up on: {0} CPU ended up on: {1}", pCash, cpuCash);
                        gameOver = true;
                    }


                }


                else if (guess > 2)
                {
                    Console.WriteLine("Incorrect input, please try again!");
                    return;

                }
                else
                {
                    Console.WriteLine("Incorrect input, please try again!");
                    return;
                }
            }
        }




    }

}

