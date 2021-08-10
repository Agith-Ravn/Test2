namespace Oppgave19._5
{
    public class Door
    {
        public Rom A { get; set; }
        public Rom B { get; set; }
        public string Farge { get; set; }
        public bool Åpent { get; set; }

        public Door(Rom a, Rom b, string farge, bool åpent)
        {
            A = a;
            B = b;
            Farge = farge;
            Åpent = åpent;
        }
    }
}