namespace Writer.Api.Models
{
    public class Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Writer()
        {

        }

        public Writer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
