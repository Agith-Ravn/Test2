using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace Øvelse1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQueries().Wait();
        }

        static async Task TestQueries()
        {
            //Kobler til Sql
                //var connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //var conn = new SqlConnection(connStr);

            //Alle kommandoer
                //var readMany = @"SELECT Id, FirstName, LastName, BirthYear
                //                 FROM Person";

                // DECLARE @Id int = 1001;
                //var readOne = @"SELECT Id, FirstName, LastName, BirthYear
                //                FROM Person
                //                WHERE Id = @Id";

                //var readOneByName = @"SELECT Id, FirstName, LastName, BirthYear
                //                      FROM Person
                //                      WHERE FirstName = @FirstName";

                //var create = @"INSERT INTO Person (FirstName, LastName, BirthYear)
                //               VALUES (@FirstName, @LastName, @BirthYear)";

                //var delete = @"DELETE FROM Person WHERE Id = @Id";

                //var deleteAll = @"DELETE FROM Person";

                //var update = @"UPDATE Person
                //               SET LastName = @LastName, FirstName = @FirstName
                //               WHERE Id = @Id";


            //Kjører de ulike kommandoene med verdier (legg merke til (create, deleteAll update over og under)
                //int rowsDeleted = await conn.ExecuteAsync(deleteAll);

                //int rowsInserted1 = await conn.ExecuteAsync(create, new { FirstName = "Terje", LastName = "Kolderup", BirthYear = 1975 });
                //int rowsInserted2 = await conn.ExecuteAsync(create, new { FirstName = "Per", LastName = (string)null, BirthYear = 1980 });
                //int rowsInserted3 = await conn.ExecuteAsync(create, new { FirstName = "Pål", LastName = (string)null, BirthYear = 1981 });

                //IEnumerable<Person> persons = await conn.QueryAsync<Person>(readMany);

                //Person terje = await conn.QueryFirstOrDefaultAsync<Person>(readOneByName, new { FirstName = "Terje" });

                //int rowsAffected2 = await conn.ExecuteAsync(update, new { FirstName = "Petter", LastName = "Pettersen", Id = terje.Id });
                //persons = await conn.QueryAsync<Person>(readMany);

                //int rowsAffected3 = await conn.ExecuteAsync(delete, new { Id = terje.Id });
                //persons = await conn.QueryAsync<Person>(readMany);
        }
    }
}
