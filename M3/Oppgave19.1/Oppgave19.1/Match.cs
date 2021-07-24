using System;

namespace Oppgave19._1
{
    public class Match
    {
        //Husk! Private = kun nås fra samme class og public fra alle class.
        //get og set bestemmer bare hvem som kan hente og endre.
        private string bet { get; set; }
        public bool IsRunning { get; private set; }
        public int homeGoals { get; private set; }
        public int awayGoals { get; private set; }
        
        public Match(string bet)
        {
            this.bet = bet;
            IsRunning = true;

        }

        public void Stop()
        {
            IsRunning = false;
        }

        public void AddGoal(string command)
        {
            if (command == "H") homeGoals++;
            else if (command == "B") awayGoals++;
        }

        public bool IsBetCorrect()
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            return bet.Contains(result);
        }

        public string GetScore()
        {
            return $"{homeGoals}-{awayGoals}";
        }
    }
}