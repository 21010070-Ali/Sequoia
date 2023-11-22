namespace Sequoia.Models
{
    public class SurveyResponse
    {
        public int ResponseID { get; set; }
        public int SurveyID { get; set; }
        public int QuestionID { get; set; }
        public string ResponseText { get; set; } = null!;

        // Navigation properties
        public Survey Survey { get; set; } = null!;
        public SurveyQuestion SurveyQuestion { get; set; } = null!;
    }


}
