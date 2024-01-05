namespace PresentHarbor.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string PhotoURL { get; set; }

        public List<Present> Presents { get; set; }
    }
}
