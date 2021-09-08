using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using NumberPuzzleWeb.Core.DomainModel;
using NumberPuzzleWeb.Core.DomainServices;
using DbGameModel=NumberPuzzleWeb.Infrastructure.DataAccess.Model.GameModel;

namespace NumberPuzzleWeb.Infrastructure.DataAccess.Repository
{
    public class GameModelRepository : IGameModelRepository
    {
        private readonly string _connectionString;

        public GameModelRepository(ConnectionString connectionString)
        {
            _connectionString = connectionString.Value;
        }

        //private const string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NumberPuzzleGame;Integrated Security=True";

        public async Task<bool> Create(GameModel gameModel)
        {
            await using var conn = new SqlConnection(_connectionString);
            const string insert =
                "INSERT INTO Game (Id, Numbers, PlayCount) VALUES (@Id, @Numbers, @PlayCount)";
            var dbGameModel = MapToDb(gameModel);
            var rowsAffected = await conn.ExecuteAsync(insert, dbGameModel);
            return rowsAffected == 1;
        }

        public async Task<GameModel> Read(Guid id)
        {
            try
            {
                //string idString = id.ToString();
                await using var conn = new SqlConnection(_connectionString);
                const string select =
                    "SELECT Id, Numbers, PlayCount FROM Game WHERE Id = @id";
                var result = await conn.QueryAsync<DbGameModel>(select, new {Id = id});
                var gameModel = result.SingleOrDefault();
                return MapToDomain(gameModel);
            }
            catch(Exception e)
            {

            }

            return null;
        }



        public async Task<bool> Update(GameModel gameModel)
        {
            await using var conn = new SqlConnection(_connectionString);
            const string insert =
                "UPDATE Game SET Numbers=@Numbers, PlayCount= @PlayCount WHERE Id=@Id";
            var dbGameModel = MapToDb(gameModel);
            var rowsAffected = await conn.ExecuteAsync(insert, dbGameModel);
            return rowsAffected == 1;
        }
        private static GameModel MapToDomain(DbGameModel gameModel)
        {
            var numbers = gameModel.Numbers.ToCharArray().Select(c => c - '0').ToArray();
            return new GameModel(gameModel.Id, gameModel.PlayCount, numbers);
        }

        private static DbGameModel MapToDb(GameModel gameModel)
        {
            var numbers = new string(gameModel.Numbers).Replace(' ', '0');
            return new DbGameModel(gameModel.Id, gameModel.PlayCount, numbers);
        }
    }
}