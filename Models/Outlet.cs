namespace Sequoia.Models
{
    public class Outlet
    {
        public string OutletID { get; set; } = null!;
        public string OutletName { get; set; } = null!;

        // Navigation properties
        public ICollection<Survey> Surveys { get; set; } = null!;
    }

}
