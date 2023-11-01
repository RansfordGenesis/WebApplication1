namespace WebApplication1.models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owner { get; set; }

    }
}
