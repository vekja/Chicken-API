namespace ChickenAPI.Models
{
    public class Chicken
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ImageURL { get; set; }

        public IEnumerable<Breed> Breeds { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }


    }
}
