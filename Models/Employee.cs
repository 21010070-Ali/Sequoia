namespace Sequoia.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; } = null!;
        public string UserPass { get; set; } = null!;// Should be hashed
        public string UserRole { get; set; } = null!;

        // Navigation properties
        public ICollection<SurveyEmployee> SurveyEmployees { get; set; } = null!;
    }


}