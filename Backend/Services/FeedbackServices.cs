using FeedbackApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackApi.Services
{
    public class FeedbackService
    {
        private readonly IMongoCollection<Feedback> _feedback;

        public FeedbackService(IFeedbackDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _feedback = database.GetCollection<Feedback>(settings.FeedbackCollectionName);
        }

        public List<Feedback> Get() =>
            _feedback.Find(feedback => true).ToList();

        public Feedback Get(string id) =>
            _feedback.Find<Feedback>(feedback => feedback.Id == id).FirstOrDefault();

        public Feedback Create(Feedback feedback)
        {
            _feedback.InsertOne(feedback);
            return feedback;
        }
    }
}
