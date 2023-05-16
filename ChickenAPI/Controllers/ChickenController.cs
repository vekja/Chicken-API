using ChickenAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChickenAPI.Controllers
{

    public interface IChickenController
    {
        public Chicken Get(int id);
        public IEnumerable<Chicken> GetAll();
        public IEnumerable<Chicken> GetByOwner(int ownerId);
        public IEnumerable<Chicken> GetByBreed(int breedId);
    }
    [ApiController]
    [Route("[controller]")]
    public class ChickenController : IChickenController
    {

        private readonly ILogger<ChickenController> _logger;

        public ChickenController (ILogger<ChickenController> logger)
        {
            _logger = logger;
        }


        public Chicken Get(int id)
        {
            throw new NotImplementedException();
            //name
            //description
            //picture
        }

        public IEnumerable<Chicken> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Chicken> GetByOwner(int ownerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Chicken> GetByBreed(int breedId)
        {
            throw new NotImplementedException();
        }
    }
}
