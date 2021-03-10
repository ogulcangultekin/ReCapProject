using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        protected readonly string imageDirectory = @"wwwroot\images";
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll(int carId)
        {
            var result = _carImageService.GetAll(carId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _carImageService.Get(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {

                return BadRequest(result);
            }

        }

        [HttpPost("add")]
        public IActionResult Add([FromForm]int carId,[FromForm]IFormFile imageFile)
        {
            try
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), imageDirectory, fileName);


                    var result = _carImageService.Add(new CarImage() {CarId=carId, ImagePath = fileName });
                    if (result.Success)
                    {
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            imageFile.CopyTo(fileStream);
                        }

                        return Ok(result);
                    }

                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return BadRequest();
        }
        [HttpPost("update")]
        public IActionResult Update(int id, int carId, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var image = _carImageService.GetAll(carId).Data.Where(x => x.Id == id).FirstOrDefault();

                string fileName = image.ImagePath;
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), imageDirectory, fileName);
                System.IO.File.Delete(filePath);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }

                image.Date = DateTime.Now;
                var result = _carImageService.Update(image);
                if (result.Success)
                    return Ok(result);
                return BadRequest(result);
            }

            return BadRequest();
        }
        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
