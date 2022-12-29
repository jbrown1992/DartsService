using DartsService.Models;

namespace DartsService.Logic
{
    public interface IScoreCalcuator
    {
        int CalculateDartScore(Dart dart);
    }
}