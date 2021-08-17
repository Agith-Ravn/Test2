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
            return $"{FirstName} {LastName} (Id={Id}) Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id}) Mor: {Mother.FirstName} (Id={Mother.Id})";
        }
    }
}