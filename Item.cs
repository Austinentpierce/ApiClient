
namespace ApiClient
{
    public class Item
    {
        public int id { get; set; }
        public string text { get; set; }
        public bool complete { get; set; }
        public DateTime completed_at { get; set; }
        public DateTime updated_at { get; set; }

    }
}