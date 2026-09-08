namespace PixelFit.DTOS.Training
{
    public class TrainingDayResponse
    {
        public int Id { get; set; }

        public int TrainingProgramId { get; set; }

        public string DayName { get; set; } = string.Empty;
    }
}