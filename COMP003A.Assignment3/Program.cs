using System.ComponentModel.Design;

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

            // Behavoir 2
            Console.Write("Do you have a valid ID? (yes/no): ");
            string idInput = Console.ReadLine();
            bool hasValidId = (idInput.ToLower() == "yes");

            Console.Write("Have you completed orientation? (yes/no): ");
            string orientationInput = Console.ReadLine();
            bool hasOrientation = (orientationInput.ToLower() == "yes");

            string readinessStatus = "";

            if (readinessCategory != "Minor" && hasValidId)
            {
                if (hasOrientation || readinessCategory == "Adult")
                {
                    readinessStatus = "Ready";
                }
                else
                {
                    readinessStatus = "Conditionally Ready";
                }
            }
            else
            {
                readinessStatus = "Not Ready";
            }

            Console.WriteLine();
            Console.WriteLine("Readiness Status: " + readinessStatus);
            Console.WriteLine();

            // Behavior 3
            Console.WriteLine("Select a guidance option: ");
            Console.WriteLine("1 - Academic Planning");
            Console.WriteLine("2 - Personal Planning");
            Console.WriteLine("3 - Career Planning");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Guidance: ");
        }   
    }
}
