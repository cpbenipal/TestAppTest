using System.Web.Http;

namespace TestApp.Controllers
{
    public class DefaultController : ApiController
    {
        /// <summary>
        /// Test
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/hello")]
        public IHttpActionResult GetHello()
        {
            return Json(new { message = "hello" });
        }
    }
}
