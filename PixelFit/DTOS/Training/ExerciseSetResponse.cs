namespace PixelFit.DTOS.Training
{
    public class ExerciseSetResponse
    {
        public int Id { get; set; }

        public int TrainingDayExerciseId { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }

        public int RestBetweenSets { get; set; }
    }
}