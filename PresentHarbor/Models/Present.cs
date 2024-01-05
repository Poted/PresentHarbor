namespace PresentHarbor.Models
{
    public class Present
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int PhotoID { get; set; }
        public Photo Photo { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
