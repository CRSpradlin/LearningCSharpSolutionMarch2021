namespace LearningCSharp
{
    public class Dinner
    {
        public string MainCourse;
        public string Desert;
        public bool HasSides;
        public string Drinks;

        public string GetPlan()
        {
            return $"For Dinner you will have {MainCourse} With {Desert}";
        }
    }
}
