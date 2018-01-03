namespace WebStoreTraining.Models
{
    public class Items
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public int ProducerId { get; set; }
        public decimal Price { get; set; }
        public string ItemArtUrl { get; set; }
        public Category Category { get; set; }
        public Producer Producer { get; set; }
    }
}