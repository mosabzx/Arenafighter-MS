using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arenafighter
{
    public class Character
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int health  { get; set; }


        public Character()
        {
            Random randstrength = new Random(DateTime.Now.Second);
            strength = randstrength.Next(1, 5);
            
            health = 60;


        }

       
        
        //This method just for testing.
        public void PlayerInfo()
        {
           
            Character player = new Character();

            //Code to Take a player name from user input.
            Console.WriteLine("Enter your name: ");
            string playerinput = Console.ReadLine();
            player.name = playerinput;

            Random randstrength = new Random(DateTime.Now.Second);
            player.strength = randstrength.Next(1, 10);

            Console.WriteLine($"Name: {player.name}\n" +
                $"Strength: {player.strength}\n" +
                $"Health: {player.health}");

        }



        
        
        
        //This methos just for testing.    
        public void OppnentInfo()
        {
            //Code to Generate random oppenent names from a list.
            Character opponent = new Character();
            List<string> oppoenentlist = new List<string>() { "Super Man", "Mario", "Scorpion",
            "Hunter","Lion","Tiger","Hulk","Ice Man"};

            Random rand1 = new Random(DateTime.Now.Second);
            int nameselect = rand1.Next(0, 8);
            opponent.name = oppoenentlist[nameselect];

            Random rand2 = new Random(DateTime.Now.Second);
            opponent.strength = rand2.Next(1, 10);

            Console.WriteLine("===============\n");
            Console.WriteLine($"Oppnent Name: {opponent.name}\n" +
                $"Strength: {opponent.strength}\n" +
                $"Health: {opponent.health}");


            

        }

      

    }



}

