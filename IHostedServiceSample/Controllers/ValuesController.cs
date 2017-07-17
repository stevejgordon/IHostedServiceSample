using Microsoft.AspNetCore.Mvc;

namespace IHostedServiceSample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly RandomStringProvider _randomStringProvider;

        public ValuesController(RandomStringProvider randomStringProvider)
        {
            _randomStringProvider = randomStringProvider;
        }

        [HttpGet]
        public string Get()
        {
            return _randomStringProvider.RandomString;
        }
    }
}