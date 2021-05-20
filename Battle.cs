using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arenafighter
{
   public class Battle
    {
        public int score { get; set; }


        public Battle()
        {
            
        }


        //Method include the main code for Battle.
        public static void FightBattle()
        {
            Character player = new Character();


            //Code to Take a player name from user input.
            Console.Write("Enter your name: ");
            string playerinput = Console.ReadLine();
            player.name = playerinput;
            

            ///Fixed by assign the random value to strength field in Character constructor.
            /*//Code to give random value for player strength.
            Random rand = new Random(DateTime.Now.Millisecond);
            player.strength = rand.Next(1, 10); */


            //assign varibales for player attributes.
            string playername = player.name;
            int playerstrength = player.strength;
            int playerhealth = player.health;

            //printing player info.
            Console.WriteLine($"Name: {playername}\n" +
                $"Strength: {playerstrength}\n" +
                $"Health: {playerhealth}");


            //create an object for plyer score.
            Battle playerscore = new Battle();
            //assign variable to playerscore.
            int playscore = playerscore.score;


            //Loop for to chose Opponents when the opponent dead in the fight.
            bool round = true;
            while (round)
            {
                Console.WriteLine("\nYou will fiaght against:\n");
                // To give time for compiler to generate new  strength value for oppnent.
                Console.ReadKey(true);


                //Code to Generate random oppoenent names from a list.
                Character opponent = new Character();
                List<string> oppoenentlist = new List<string>() { "Super Man", "Spider Man", "Scorpion",
                "Hunter","Lion","Tiger","Hulk","Bat Man"};

                Random rand1 = new Random(DateTime.Now.Second);
                int nameselect = rand1.Next(0, 8);
                opponent.name = oppoenentlist[nameselect];


                ///Fixed by assign the random value to strength field in Character constructor.
                /*//code to give random value for opponent strength characters.
                Random rand2 = new Random(DateTime.Now.Second);
                opponent.strength = rand2.Next(1, 10); */


                //assign variables for opponent attributes.
                string opponentname = opponent.name;
                int opponentstrength = opponent.strength;
                int opponenthealth = opponent.health;


                //printing opponent info.
                Console.WriteLine($"Oppnent Name: {opponentname}\n" +
                    $"Strength: {opponentstrength}\n" +
                    $"Health: {opponenthealth}\n");


                
                Console.WriteLine("Are you ready to fight Hit enter to proceed.....");
                Console.ReadKey(true);


                //diceroll loop for each opponent until dead.
                bool fight = true;
                while (fight) 
                {
                    
                    
                    //code to generate a diceroll.
                    Round diceroll = new Round();
                    int dicerollnum = diceroll.dice;
                    Console.WriteLine("\nDiceroll is: {0}", dicerollnum);

                    //adding the dice value for both characters.
                    playerstrength += dicerollnum;
                    opponentstrength += dicerollnum;



                    //Conditions to check the results.
                    if (playerstrength > opponentstrength)
                    {
                        opponenthealth -= playerstrength;
                        Console.WriteLine($"{playername} You Win! This Round");
                        playscore += 1;
                        Console.WriteLine($"{playername} Your Score: {playscore}");
                        Console.WriteLine("Your Health is: {0}", playerhealth);

                        Console.WriteLine($"{opponentname} Health: {opponenthealth }");

                        Console.WriteLine("Click (c) to Continue, (e) To End The Fight! ");
                        string select = Console.ReadLine();
                        if (select == "c")
                        {

                            Console.Clear();
                            
                        }
                        else if (select == "e")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("GAME OVER! You End The Match!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{playername} Your Wining Score is: {playscore}\n" +
                                $"Your Strength is: {playerstrength}\n" +
                                $"Your Health is {playerhealth}");
                            Console.ResetColor();


                            fight = false; // break the fight loop.
                            round = false; // break the round loop.
                            

                        }

                    }


                    else if (opponentstrength > playerstrength)
                    {
                        playerhealth -= opponentstrength;
                        Console.WriteLine($"{playername} Sorry you lose This Round\n" +
                            $"Try again..");
                        Console.WriteLine($"Your Health: {playerhealth}\n" +
                            $"{opponentname} Health is : {opponenthealth}");
                        
                        Console.ReadKey();
                        Console.Clear();


                    }

                    if (playerhealth <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"{playername} Your health is 0 you dead");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("GAME OVER!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{playername} Your Wining Score is: {playscore}\n" +
                            $"Your Strength is: {playerstrength}\n" +
                            $"Your Health is {playerhealth}");


                        fight = false; // break the fight loop.
                        round = false; // break the round loop.


                    }

                    else if (opponenthealth <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{opponentname} Is Dead !");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{playername} Your Wining Score is: {playscore}\n" +
                            $"Your Strength is: {playerstrength}\n" +
                            $"Your Health is {playerhealth}");

                        Console.ResetColor();
                        Console.WriteLine("Go ahead fight with another oppnent");
                        Console.ReadLine();

                        fight = false; //just breaking the fight loop to let the player fight another opponent.


                    }


                    //Condition to apply breaking the fight loop upon Oppnent status.
                    if (fight == false && opponenthealth <= 0)
                    {
                        break;
                    }




                }

                //Condition to apply breaking the round loop upon player status.
                if (round == false && playerhealth <= 0)
                {
                    break;
                }


                
            }


           

        }

            
                
            

            





        
        


       
        

      
    }
}
