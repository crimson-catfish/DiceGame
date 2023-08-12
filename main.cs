Random dice = new Random();

int roll1;
int roll2;
int roll3;
int sumPoints;
int winCount = 0;
int loseCount = 0;

string userInput;


Console.WriteLine(@"
---The Dice Game---

Rules:
1 If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
2 If all three dice you roll result in the same value, you get six bonus points for rolling triples.
3 If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.");

while (true)
{
    Console.Write("\nto roll dices type \"r\", to exit type \"e\"  ");
    userInput = Console.ReadLine();
    if (userInput == "e")
    {
        break;
    }
    if (userInput == "r")
    {
        Console.WriteLine($"\nfirst dice:\t{roll1 = dice.Next(1, 7)}\nsecond dice:\t{roll2 = dice.Next(1, 7)}\nthird dice:\t{roll3 = dice.Next(1, 7)}\n");
        sumPoints = roll1 + roll2 + roll3;
        if (roll1 == roll2 && roll1 == roll3)
        {
            sumPoints += 6;
            Console.WriteLine("You got TRIPLE! 6 bonus points\n");
        }
        else if (roll1 == roll2 | roll2 == roll3 | roll1 == roll3)
        {
            sumPoints += 2;
            Console.WriteLine("You got double! 2 bonus points\n");
        }
        if (sumPoints >= 15)
        {
            Console.WriteLine($"Total points:\t{sumPoints}\tYOU WIN!\n");
            winCount += 1;
        }
        else
        {
            Console.WriteLine($"Total points:\t{sumPoints}\tYOU LOSE\n");
            loseCount += 1;
        }
        Console.WriteLine($"Wins: {winCount}\tLoses: {loseCount}\tYou have "+ (100 * winCount / (winCount + loseCount)) + "% winrate\n\n");
    }
}