namespace Sequoia.Models
{
    public class Treatment
    {
        public string TreatmentID { get; set; } = null!;
        public string TreatmentName { get; set; } = null!;

        // Navigation properties
        public ICollection<Survey> Surveys { get; set; } = null!;
    }


}
