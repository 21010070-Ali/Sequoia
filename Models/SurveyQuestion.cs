namespace Sequoia.Models
{
    public class SurveyQuestion
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; } = null!;
        public bool IsActive { get; set; }

        // Navigation properties
        public ICollection<SurveyResponse> SurveyResponses { get; set; } = null!;
    }

}
