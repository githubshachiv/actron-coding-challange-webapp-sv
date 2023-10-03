//using FindLargestNumberAPI.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace FindLargestNumberAPI.Controllers
//{
//    [ApiController]
//    [Route("api/cities")]
//    public class FindLargestNumberController : ControllerBase
//    {
//        [HttpGet]
//        public ActionResult<IEnumerable<CityDto>> GetCities()
//        {
//            return Ok(CitiesDataStore.Current.Cities);
//        }

//        [HttpGet("{id}")]
//        public ActionResult<CityDto> GetCity(int id)
//        {
//            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

//            if (cityToReturn == null)
//            {
//                return NotFound();
//            }
//            return Ok(cityToReturn);
//        }

//        [HttpPost]
//        public ActionResult<string> GetLargestNumber(InputArrayDto inputArrayDto)
//        {
//            string output = string.Empty;
//            if (inputArrayDto == null || inputArrayDto.Items.Count == 0)
//            {
//                //exampleJson = "{\n  \"output\" : \"No input\"\n}";
//                //var example = JsonConvert.DeserializeObject<InlineResponse400>(exampleJson);
//                return StatusCode(400, "No Input");//new ObjectResult(example);
//            }
//            else
//            {
//                List<int> temp = inputArrayDto.Items;
//                var containsNegatives = temp.Any(n => n < 0);
//                if (containsNegatives)
//                {

//                    return StatusCode(400, "Negative numbers in input");
//                }
//            }
//            output = LargestNumberClass.LargestNumberMethod(inputArrayDto.Items);
//            return Ok(output);

//        }
//    }
//}
