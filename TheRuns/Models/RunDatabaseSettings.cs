namespace TheRuns.Models
{
	public class RunDatabaseSettings : IRunDatabaseSettings
	{
		public string RunsCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IRunDatabaseSettings
	{
		string RunsCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}
