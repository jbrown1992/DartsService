namespace DartsService.Models
{
    public class Leg
    {
        public List<Dart> Darts { get; set; }
        public int RemainingScore { get; set; } = 0;
        public int CurrentScore { get; set; } = 0;
        public int StartingValue { get; set; } = 501; //TODO: currently just 501, but may need to change to include 301
    }
}
