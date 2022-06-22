using MongoDB.Bson;
using MongoDB.Driver;
using TheRuns.Models;
using TheRuns.Models.DB;
using TheRuns.Services.Utils;

namespace TheRuns.Services
{
    public class RunService : IRunService
    {
        private readonly IMongoCollection<RunDto> runs;

        public RunService(IRunDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            runs = database.GetCollection<RunDto>(settings.RunsCollectionName);
        }

        public List<RunDetails> GetUserRuns(Guid userId)
        {
            var runList = runs.Find(r => r.UserId == userId).ToList();
            var runDetailsList = RunServiceUtils.MapToRunDetailsList(runList);
            return runDetailsList;
        }

        //public RunDetails GetRunDetails(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public string CreateRun(RunDetails runDetails)
        {
            var newRun = RunServiceUtils.MapToDto(runDetails);
            runs.InsertOne(newRun);
            var id = newRun.Id;
            return id;
        }

        public RunDetails UpdateRun(RunDetails run)
        {
            throw new NotImplementedException();
        }

        public void DeleteRun(int id)
        {
            throw new NotImplementedException();
        }
    }
}
