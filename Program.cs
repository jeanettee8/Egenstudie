namespace Egenstudie;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        bool running = true;
        int playerWins = 0;
        int enemyWins = 0;
        while (running) {
            int enemyNumber = rnd.Next(1, 7);
            int playerNumber = rnd.Next(1, 7);
            Console.WriteLine("Press any key to roll the dice.");
            Console.ReadKey();
            Console.WriteLine($"You rolled a {playerNumber}");
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine($"Enemy AI rolled a {enemyNumber}");
                if (enemyNumber<playerNumber) {
                    Console.WriteLine("Player wins the round!");
                    playerWins ++;
                    }
                else if (playerNumber<enemyNumber) {
                    Console.WriteLine("Enemy wins the round!");
                    enemyWins ++;
                    }
                else {
                    Console.WriteLine("It's a tie! No points awarded.");
                    }
            Console.WriteLine($"The score is now - Player : {playerWins}. Enemy : {enemyWins}.");
            Console.ReadKey();
                if (playerWins == 5 || enemyWins == 5) {
                    running = false;
                }
        }
        Console.WriteLine(playerWins == 5 ? "PLAYER WINS THE GAME!" : "ENEMY WINS THE GAME!");
        Console.ReadKey();
    }
}


// Ting du kan adde: la player og enemy skrive inn sitt navn, så står det navn istedenfor "Player" og "Enemy AI"
