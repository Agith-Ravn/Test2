namespace Oppgave19._6
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }

        public Person Mother { get; set; }
        public Person Father { get; set; }

        public Person(int id, string firstName, string lastName, int birthYear, int deathYear, Person mother, Person father)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            DeathYear = deathYear;
            Mother = mother;
            Father = father;
        }

        public Person(int id, string firstName)
        {
            Id = id;
            FirstName = firstName;
        }

        public Person()
        {
        }

        public string GetDescription()
        {
            string txt = "";
            if (FirstName != null) txt += $"{FirstName} ";
            if (LastName != null) txt += $"{LastName} ";
            if (Id != 0) txt += $"(Id={Id}) ";
            if (BirthYear != 0) txt += $"Født: {BirthYear} ";
            if (DeathYear != 0) txt += $"Død: {DeathYear} ";
            if (Father != null) txt += $"Far: {Father.FirstName} (Id={ Father.Id}) ";
            if (Mother != null) txt += $"Mor: {Mother.FirstName} (Id={ Mother.Id}) ";
            return txt.TrimEnd();
        }
    }
}