namespace PixelFit.DTOS.Training
{
    public class ExerciseResponse
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int MuscleGroupId { get; set; }

        public string MuscleGroupName { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}