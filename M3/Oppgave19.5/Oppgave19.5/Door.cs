namespace Oppgave19._5
{
    public class Door
    {
        private string A { get; set; }
        private string B { get; set; }
        private string Farge { get; set; }
        private bool Åpent { get; set; }

        public Door(string a, string b, string farge, bool åpent)
        {
            A = a;
            B = b;
            Farge = farge;
            Åpent = åpent;
        }
    }
}