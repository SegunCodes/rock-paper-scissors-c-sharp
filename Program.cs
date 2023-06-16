using System;
namespace MyFirstProgram;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        String player;
        String computer;
        String response;

        while (playAgain)
        {
            player = "";
            computer = "";

            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }

            switch (random.Next(1,4))
            {
                case 1:
                    computer = "PAPER";
                    break;
                case 2:
                    computer = "ROCK";
                    break;
                case 3: 
                    computer = "SCISSORS";
                    break;
            }

            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);

            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw");
                    }
                    else if (computer == "PAPER"){
                        Console.WriteLine("You lose");
                    }else{
                        Console.WriteLine("You win");
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You win");
                    }
                    else if (computer == "PAPER"){
                        Console.WriteLine("It's a draw");
                    }else{
                        Console.WriteLine("You lose");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You lose");
                    }
                    else if (computer == "PAPER"){
                        Console.WriteLine("You win");
                    }else{
                        Console.WriteLine("It's a draw");
                    }
                    break;
            }


            Console.WriteLine("Would you like to play again? (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();
            if (response == "Y")
            {
                playAgain = true;
            }else{
                playAgain = false;
            }
        }
        Console.WriteLine("Thanks for playing");
        Console.ReadKey();
    }
}