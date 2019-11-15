using System.Linq;

namespace App
{
    public class AnswerChecker
    {
        private static string[] answersPositive = 
        {
            "y",
            "yes",
            "д",
            "да"
        };

         private static string[] answersNegative = 
        {
            "n",
            "no",
            "н",
            "нет"
        };

        public static bool isPositiveAnswer(string answer)
        {
            if (answersPositive.Contains(answer))
            {
                return true;
            }

            return false;
        }

        public static bool isNegativeAnswer(string answer)
        {
            if (answersNegative.Contains(answer))
            {
                return true;
            }

            return false;
        }
    }
}