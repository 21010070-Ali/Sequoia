namespace Sequoia.Models
{
    public class SurveyEmployee
    {
        public int SurveyID { get; set; }
        public int EmpID { get; set; }

        // Navigation properties
        public Survey Survey { get; set; } = null!;
        public Employee Employee { get; set; } = null!;
    }

}