namespace PixelFit.DTOS.Training
{
    public class WorkoutExercise
    {
        public int TrainingDayExerciseId { get; set; }

        public int ExerciseId { get; set; }

        public string ExerciseName { get; set; }
            = string.Empty;

        public string ImageUrl { get; set; }
            = string.Empty;

        public int Order { get; set; }

        public List<ExerciseSetResponse> Sets { get; set; }
            = new();
    }
}