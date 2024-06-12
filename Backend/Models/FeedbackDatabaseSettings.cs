namespace FeedbackApi.Models
{
    public class FeedbackDatabaseSettings : IFeedbackDatabaseSettings
    {
        public string FeedbackCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IFeedbackDatabaseSettings
    {
        string FeedbackCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
