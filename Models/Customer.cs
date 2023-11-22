namespace Sequoia.Models
{
    public class Customer
    {
        public int CustID { get; set; }
        public string CustGender { get; set; } = null!;
        public int CustAge { get; set; }

        // Navigation properties
        public ICollection<Survey> Surveys { get; set; } = null!;
    }


}