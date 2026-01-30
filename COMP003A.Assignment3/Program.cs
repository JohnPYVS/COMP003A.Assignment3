namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Academic & Personal Readiness Evaluator ===");
            Console.WriteLine();

            // Behavior 1
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Current Year: " + currentYear);

            Console.WriteLine("Enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            int age = currentYear - birthYear;
            Console.WriteLine();
            Console.WriteLine("Calculated Age: " + age);

            string readinessCategory = "";
            if (age < 18)
            {
                readinessCategory = "Minor";
            }
            else if (age <= 25)
            {
                readinessCategory = "Adult";
            }

            Console.WriteLine("Readiness Category: " + readinessCategory);
            Console.WriteLine();

        }
    }
}
