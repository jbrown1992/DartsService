using DartsService.Logic;
using DartsService.Models;
using Microsoft.AspNetCore.Mvc;

namespace DartsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DartsController : ControllerBase
    {
        private readonly ILogger<DartsController> _logger;
        public IScoreCalcuator _scoreCalcuator;

        public DartsController(ILogger<DartsController> logger, IScoreCalcuator scoreCalcuator)
        {
            _logger = logger;
            _scoreCalcuator = scoreCalcuator;
        }

        [HttpPost(Name = "ThrowDart")]
        public int ThrowDart(Dart dart)
        {
            return _scoreCalcuator.CalculateDartScore(dart);
        }
    }
}