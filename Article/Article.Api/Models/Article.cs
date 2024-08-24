namespace Aricle.Api.Models
{
    public class Article
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime LastUpdate { get; set; }
        public int WriterId { get; set; }

        public Article()
        {

        }

        public Article(int id, string title, DateTime lastUpdate, int writerId)
        {
            Id = id;
            Title = title;
            LastUpdate = lastUpdate;
            WriterId = writerId;
        }
    }
}
