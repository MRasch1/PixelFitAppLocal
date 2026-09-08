namespace PixelFit.DTOS.Training
{
    public class ProgramExerciseViewModel
    {
        public int Id { get; set; }

        public string ExerciseName { get; set; } =
            string.Empty;

        public string ImageUrl { get; set; } =
            string.Empty;

        public int Order { get; set; }

        public List<ExerciseSetResponse> Sets { get; set; } =
            new();
    }
}