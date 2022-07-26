using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Absract;
using RentACar.Entities.Concrete;

namespace RentACarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private  IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            return result.Success ? Ok(result.Data) : BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            return result.Success ? Ok(result.Message) : BadRequest();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            return result.Success ? Ok(result.Message) : BadRequest();
        }

        [HttpPatch("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            return result.Success ? Ok(result.Message) : BadRequest();
        }

    }
}
