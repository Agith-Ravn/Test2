namespace Oppgave19._3
{
    public class BoardModel
    {
        private CellModel[] Cells { get; set; }

        public BoardModel()
        {
            Cells = new CellModel[9];
            for (int i = 0; i < Cells.Length; i++)
            {
                Cells[i] = new CellModel();
            }
        }
    }
}