namespace PixelFit.DTOS.Food
{
    public class MealResponse
    {
        public int Id { get; set; }

        public string MealType { get; set; } =
            string.Empty;

        public DateTime Date { get; set; }

        public List<FoodItemResponse> Items { get; set; } =
            new();
    }
}