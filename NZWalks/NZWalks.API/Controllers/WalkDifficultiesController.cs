using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalkDifficultiesController : Controller
    {
        private readonly IWalkDifficultyRepository walkDifficultyRepository;

        public WalkDifficultiesController(IWalkDifficultyRepository walkDifficultyRepository)
        {
            this.walkDifficultyRepository = walkDifficultyRepository;
        }


        [HttpGet]

        public async Task<ActionResult>GetAllWalkDifficulties()
        {

            var walkDifficulties = await walkDifficultyRepository.GetAllAsync();

            if (walkDifficulties == null) return NotFound();
             
            // This is an example returning the domain model.

            return Ok(walkDifficulties);

             
        }


    }
}
