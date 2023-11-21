using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Querys.Dogs;
using Application.Querys.Dogs.GetDogById;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        internal readonly IMediator _mediatR;

        public DogsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        // Detta är en API endpoint där vi hämtar alla hudar från MockDatabase
        //Url är api/v1/Dogs/getAllDog
        [HttpGet]
        [Route("getAllDogs")]
        public async Task<IActionResult> GetAllDogs()
        {
            // Använda MEDIATOR
            // MediatR ska ta emot request och dela de på commands eller Queries
            // Detta är en Get, då blir det en query
            // return IActionResult
            
            return Ok(await _mediatR.Send(new GetAllDogsQuery()));
        }

        [HttpGet]
        [Route("getDogsByID/{dogID}")]
        public async Task<IActionResult> GetDogById(Guid dogID)
        {
            return Ok(await _mediatR.Send(new GetDogByIdQuery(dogID)));
        }

        //// GET api/<DogController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<DogController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<DogController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<DogController>/5
        [HttpDelete]
        [Route("DeleteDogById")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
