using System;

namespace Oppgave19._3
{
    public class BoardModel
    {
        private CellModel[] Cells { get; set; }
        private Random random = new Random();

        public BoardModel()
        {
            Cells = new CellModel[9];
            for (int i = 0; i < Cells.Length; i++)
            {
                Cells[i] = new CellModel();
            }
        }

        public void SetPlayer1(string position)
        {
            if (position == "a1") Cells[0].ChangeCellContent("x");
            if (position == "b1") Cells[1].ChangeCellContent("x");
            if (position == "c1") Cells[2].ChangeCellContent("x");

            if (position == "a2") Cells[3].ChangeCellContent("x");
            if (position == "b2") Cells[4].ChangeCellContent("x");
            if (position == "c2") Cells[5].ChangeCellContent("x");

            if (position == "a3") Cells[6].ChangeCellContent("x");
            if (position == "b3") Cells[7].ChangeCellContent("x");
            if (position == "c3") Cells[8].ChangeCellContent("x");

        }

        public void SetPlayer2()
        {
            int randomIndex = random.Next(0, 9);
            do
            {
                randomIndex = random.Next(0, 9);
                if (Cells[randomIndex].CheckIfEmpty() == true)
                {
                    Cells[randomIndex].ChangeCellContent("o");
                    break;
                }

            } while (Cells[randomIndex].CheckIfEmpty() == false);

        }

        public string GetCellModel(int i)
        {
            return Cells[i].GetCellContent();
        }
    }
}