using System;

namespace Oppgave19._4
{
    public class Player
    {
        private string Name { get; set; }
        private int Score { get; set; }
        private readonly Random random = new Random();

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public void Play(Player player2)
        {
            int winnerIndex = random.Next(1, 2);
            if (winnerIndex == 1) Score -= 1;
            if (winnerIndex == 2) player2.Score += 1; 
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"{Name} Poeng: {Score}");
        }
    }
}