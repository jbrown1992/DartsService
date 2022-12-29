using DartsService.Models;

namespace DartsService.Logic
{
    public class ScoreCalcuator : IScoreCalcuator
    {
        public int CalculateDartScore(Dart dart)
        {
            var number = dart.Number;
            var multiplier = dart.Multiplier;

            var score = 0;
            multiplier = multiplier.ToUpper();

            if (multiplier == "SINGLE")
            {
                score = number * 1;
            }

            else if (multiplier == "DOUBLE")
            {
                score = number * 2;
            }

            else if (multiplier == "TRIPLE")
            {
                score = number * 3;
            }

            return score;


        }
    }
}
