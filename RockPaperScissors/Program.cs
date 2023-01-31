// See https://aka.ms/new-console-template for more information
using RockPaperScissors;

Console.WriteLine("Hello, World!");
//rock
string rock = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)";

string paper = @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)";

string scissors = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)";

//gotta displllay the options of rock paper scissors, and have a scoreboard displaying the results.



//gotta have a way for the player to pick their chosen sign
//after the player picks their sign, the computer will pick their sign.
//There needs to be a list of rules of what beats what. rock/paper/scisors has to have specified rules for each scenario, doesn't equate to a number less than/greater than relationship.
//possible matchups:
//rock vs scissors. == rock wins
//rock vs paper. == paper wins
//paper vs scissors. == scissors wins
//after each round, the winner's score is addded to their classes' .Score property.

//TODO
//Create NPC class to hold npc score and to get a random  choice for the NPC

//create player class to hold the player score and hold the choice of the player. Optionally have a highScore associated with that player.

//create a game class that starts the process of looping matches and will quit if the player types quit.
//ccreate a match class that gathers actual input from the user, gets the npc's choice, and assesses the winner.


Game game = new Game();

game.Run();