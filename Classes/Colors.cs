

namespace Week1ObjectOriented.Classes
{
    public static class Colors
    {
        static List<string> colors = new List<string>
        {
            "Yellow",
            "Red",
            "Blue",
            "Green",
            "Orange"
        };

        public static string GetRandomColor()
        {
           
            var random = new Random();
            var firstIndex = 0;
            var lastIndex = colors.Count;

            var randomColor = random.Next(firstIndex, lastIndex);


            return colors[randomColor];
        }
      
    }
}
