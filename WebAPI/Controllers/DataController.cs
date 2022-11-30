using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : Controller
    {
        [HttpPost]
        [Route("Add")]
        public ResponseClass Add(RequestClass req)
        {
            ResponseClass resp = new ResponseClass();

            try
            {
                int sumResult = 0;
                if (req.Request != null)
                {
                    foreach (int item in req.Request)
                    {
                        sumResult += item;
                    }
                }
                else
                {
                    sumResult = 0;
                }

                resp.Result = Convert.ToString(sumResult);
            }
            catch(Exception ex)
            {
                resp.Result = "The Error has Occured : " + ex.Message;
            }

            return resp;
        }

        [HttpPost]
        [Route("Multiply")]
        public ResponseClass Multiply(RequestClass req)
        {
            ResponseClass resp = new ResponseClass();
            try
            {
                int multiplyResult = 1;

                if (req.Request != null)
                {
                    foreach (int item in req.Request)
                    {
                        multiplyResult = multiplyResult * item;
                    }
                }
                else
                {
                    multiplyResult = 0;
                }
                
                resp.Result =    Convert.ToString(multiplyResult);
            }
            catch(Exception ex)
            {
                resp.Result = "The Error has Occured : " + ex.Message;
            }
            return resp;
        }
    }
}
