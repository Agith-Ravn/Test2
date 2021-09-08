using System;

namespace NumberPuzzleWeb.Infrastructure.DataAccess.Model
{
    public class GameModel
    {
        string IdString { get; set; }
        public Guid Id
        {
            get
            {
                return new Guid(IdString);
            }
            set
            {
                IdString = value.ToString();
            }
        }

        public int PlayCount { get; set; }
        public string Numbers { get; set; }

        public GameModel()
        {
        }

        public GameModel(Guid id, int playCount, string numbers)
        {
            Id = id;
            PlayCount = playCount;
            Numbers = numbers;
        }
    }
}