namespace PresentHarbor.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<Present> Presents { get; set; }
    }
}
