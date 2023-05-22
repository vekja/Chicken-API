namespace ChickenAPI.Models
{
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Chicken> Chickens { get; set;}

    }
}
