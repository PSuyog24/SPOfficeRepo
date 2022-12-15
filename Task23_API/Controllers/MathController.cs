using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task23_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        // POST api/<MathController>
        [HttpPost]
        [Route("Add")]
        public BodyClass Add(BodyClass body)
        {
            BodyClass bodyClass = new();
            try
            {
                bodyClass.Result = Convert.ToInt64(body.FirstNum) + Convert.ToInt64(body.SecondNum);
            }
            catch (Exception ex)
            {
                bodyClass.Error = "Error has occured : " + ex.Message;
            }
            return bodyClass;
        }

        [HttpPost]
        [Route("Multiply")]
        public BodyClass Multiply(BodyClass body)
        {
            BodyClass bodyClass = new();
            try
            {
                bodyClass.Result = Convert.ToInt64(body.FirstNum) * Convert.ToInt64(body.SecondNum);
            }
            catch (Exception ex)
            {
                bodyClass.Error = "Error has occured : " + ex.Message;
            }
            return bodyClass;
        }
    }
}
