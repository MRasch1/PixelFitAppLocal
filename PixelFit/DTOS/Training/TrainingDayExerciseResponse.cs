namespace PixelFit.DTOS.Training
{
    public class TrainingDayExerciseResponse
    {
        public int Id { get; set; }

        public int TrainingDayId { get; set; }

        public int ExerciseId { get; set; }

        public string ExerciseName { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public int RestBetweenExercises { get; set; }

        public int Order { get; set; }
    }
}