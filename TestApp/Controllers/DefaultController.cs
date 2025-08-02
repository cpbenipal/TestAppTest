using System.Web.Http;

namespace TestApp.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("api/hello")]
        public IHttpActionResult GetHello()
        {
            return Json(new { message = "hello" });
        }
    }
}
