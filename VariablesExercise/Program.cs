namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Dylan";
            int myAge = 19;
            char dollar = '$';
            bool iLikeCheese = true;
            double cash = 100.05;
            decimal checkingAccount = 600.97m;

            Console.WriteLine($"My name is {myName}, I am {myAge} year(s) old, I currently have {dollar}{cash} in cash.");
        }
    }
}
