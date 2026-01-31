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

            if (!hasValidId || readinessCategory == "Minor")
            {
                readinessStatus = "Not Ready";
            }
            else
            {
                if (hasOrientation)
                    readinessStatus = "Ready";
                else
                    readinessStatus = "Conditionally Ready";

            }

                Console.WriteLine();
            Console.WriteLine("Readiness Status: " + readinessStatus);
            Console.WriteLine();

            // Behavior 3
            Console.WriteLine("Select a guidance option:");
            Console.WriteLine("1 - Academic Planning");
            Console.WriteLine("2 - Personal Planning");
            Console.WriteLine("3 - Career Planning");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Guidance:");

            switch (choice)
            {
                case 1:
                    if (readinessStatus == "Not Ready")
                        Console.WriteLine("First, take care of your readiness requirements (ID/category).Then schedule a meeting with your academic advisor, for the next term. ");
                    else if (readinessStatus == "Condtionally Ready")
                        Console.Write("Meet with your advisor to plan out your next term and complete your orientation to become ready.");
                    else
                        Console.WriteLine("Sign up for your classes related to your degree, and if you want to get the most out of your schedule, make an appointment with your academic advisor. ");
                    break;

                case 2:
                    if (readinessStatus == "Not Ready")
                        Console.WriteLine("Make sure to get your necessary paperwork and complete other important tasks before making any other plans. ");
                    else if (readinessStatus == "Conditionally Ready")
                        Console.WriteLine("You're almost done; complete the last step of your orientation, and then create weekly goals to keep yourself on track. ");
                    else
                        Console.WriteLine("Plan ahead and build a strong routine");
                    break;

                case 3:
                    if (readinessStatus == "Not Ready")
                        Console.WriteLine("Create or update your resume and look into careers, while you complete your rediness requirements. ");
                    else if (readinessStatus == "Conditionally Read")
                        Console.WriteLine("You're right there but you must finish the orientation, then start building your resume and apply for internships. ");
                    else
                        Console.WriteLine("Apply for Internships or any jobs that is posted. Make sure to make connections/network and practice for interviews. ");
                    break;

                default:
                    Console.WriteLine("Error. Plese choose 1, 2, or 3.");
                    break;
            }
            
        }   
    }
}
