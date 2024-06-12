using FeedbackApi.Models;
using FeedbackApi.Services;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Collections.Generic;

namespace FeedbackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly FeedbackService _feedbackService;

        public FeedbackController(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet]
        public ActionResult<List<Feedback>> Get() =>
            _feedbackService.Get();

        [HttpGet("{id:length(24)}", Name = "GetFeedback")]
        public ActionResult<Feedback> Get(string id)
        {
            var feedback = _feedbackService.Get(id);

            if (feedback == null)
            {
                return NotFound();
            }

            return feedback;
        }

        [HttpPost]
        public ActionResult<Feedback> Create(Feedback feedback)
        {
            if (string.IsNullOrEmpty(feedback.Id))
            {
                feedback.Id = ObjectId.GenerateNewId().ToString();
            }

            _feedbackService.Create(feedback);
            return CreatedAtRoute("GetFeedback", new { id = feedback.Id.ToString() }, feedback);
        }
    }
}
