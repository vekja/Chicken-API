namespace ChickenAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        public IEnumerable<Chicken> Chickens { get; set; }
    }
}
