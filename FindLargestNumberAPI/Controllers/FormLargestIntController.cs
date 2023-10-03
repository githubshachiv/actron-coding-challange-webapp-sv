using FindLargestNumberAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FindLargestNumberAPI.Controllers
{
    [ApiController]
    [Route("api/formlargestint")]
    public class FormLargestIntController: ControllerBase 
    {
        [HttpPost]
        public ActionResult<string> GetLargestNumber(InputArrayDto inputArrayDto)
        {
            string output = string.Empty;
            if (inputArrayDto == null || inputArrayDto.Items.Count == 0)
            {
                return BadRequest("No Input");//StatusCode(400, "No Input");
            }
            else
            {
                List<int> temp = inputArrayDto.Items;
                var containsNegatives = temp.Any(n => n < 0);
                if (containsNegatives)
                {

                    return BadRequest("Negative numbers in input");//StatusCode(400, "Negative numbers in input");
                }
            }
            output = LargestNumberClass.LargestNumberMethod(inputArrayDto.Items);
            return Ok(output);

        }
    }
}
