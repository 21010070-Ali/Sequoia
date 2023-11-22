namespace Sequoia.Models
{
    public class Survey
    {
        public int SurveyID { get; set; }
        public string OutletID { get; set; } = null!;
        public int? CustID { get; set; } // Nullable if Customer is not mandatory
        public string TreatmentID { get; set; } = null!;

        // Navigation properties
        public Outlet Outlet { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public Treatment Treatment { get; set; } = null!;
        public ICollection<SurveyResponse> SurveyResponses { get; set; } = null!;
        public ICollection<SurveyEmployee> SurveyEmployees { get; set; } = null!;
    }

}
