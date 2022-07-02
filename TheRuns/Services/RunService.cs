using MongoDB.Bson;
using MongoDB.Driver;
using TheRuns.Models;
using TheRuns.Models.DB;
using TheRuns.Models.Requests;
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

        public List<RunDetails> GetUserRuns(string userId)
        {
            var runList = runs.Find(r => r.UserId == userId).ToList();
            var runDetailsList = RunServiceUtils.MapToRunDetailsList(runList);
            return runDetailsList;
        }

        public string CreateRun(CreateRunRequest run)
        {
            var newRun = RunServiceUtils.CreateRunDto(run);
            runs.InsertOne(newRun);
            var id = newRun.Id;
            return id;
        }

        public void UpdateRun(UpdateRunRequest runRequest)
        {
            var runToUpdateId = runs.Find(run => run.Id == runRequest.StringId).SingleOrDefault().Id;
            var runToInsert = RunServiceUtils.UpdateRunDto(runRequest);
            runToInsert.Id = runToUpdateId;
            runs.ReplaceOne(r => r.Id == runToUpdateId, runToInsert);
        }

        public void DeleteRun(string id)
        {
            var runToDelete = runs.Find(r => r.Id == id).FirstOrDefault();
            if (runs != null)
            {
                runs.DeleteOne(r => r.Id == runToDelete.Id);
            }
        }
    }
}
