using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExampleMicroservice.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ExampleController
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return await Task.FromResult("hello world");
        }
    }
}
