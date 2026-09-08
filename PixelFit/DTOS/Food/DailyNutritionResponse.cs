namespace PixelFit.DTOS.Food
{
    public class DailyNutritionResponse
    {
        public DateTime Date { get; set; }

        public int DailyCalorieGoal { get; set; }

        public int TotalCalories { get; set; }

        public int RemainingCalories { get; set; }

        public double Protein { get; set; }

        public double Carbs { get; set; }

        public double Fat { get; set; }

        public double Fiber { get; set; }

        public List<MealResponse> Meals { get; set; } =
            new();
    }
}