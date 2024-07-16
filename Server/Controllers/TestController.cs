using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YugiTrivia.Server.Interfaces;

namespace YugiTrivia.Server.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestRepository _TestRepository;

        public TestController(ITestRepository TestRepository)
        {
            _TestRepository = TestRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetRandomCard()
        {
            try
            {
                var randomCard = await _TestRepository.GetRandomCard();
                return Ok(randomCard);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
