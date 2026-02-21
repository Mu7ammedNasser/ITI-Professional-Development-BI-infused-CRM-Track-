namespace lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exeFolder = AppContext.BaseDirectory;
            string filePath = Path.Combine(exeFolder, "QDB.txt");
            fileReader reader = new fileReader();
            List<Question> questions = reader.ReadQuestions(filePath);

            Console.WriteLine("Please select the type of exam:");
            Console.WriteLine("1. Practice Exam");
            Console.WriteLine("2. Final Exam");
            Console.Write("Enter your choice (1 or 2): ");

            bool isPracticeExam = false;

            while (true)
            {
                string? choice = Console.ReadLine()?.Trim();

                if (choice == "1")
                {
                    isPracticeExam = true;
                    Console.WriteLine("\n*** You selected: Practice Exam ***\n");
                    break;
                }
                else if (choice == "2")
                {
                    isPracticeExam = false;
                    Console.WriteLine("\n*** You selected: Final Exam ***\n");
                    break;
                }
                else
                {
                    Console.Write("Invalid choice! Enter valid choice (1 or 2): ");
                }
            }

            int totalScore = 0;
            int earnedScore = 0;

            // Display each question
            foreach (var item in questions)
            {
                totalScore += item.Mark;  // Add this question's marks to total
                item.DisplayQues(isPracticeExam);

                // Check if answer is correct and add to earned score
                if (item.storeStudentAnswer())
                {
                    earnedScore += item.Mark;
                }
            }

            // Display final score
            if (isPracticeExam)
                return;
            Console.Clear();
            Console.WriteLine("\n╔════════════════════════════════════╗");
            Console.WriteLine("║       EXAM COMPLETE!               ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine($"Total Questions: {questions.Count}");
            Console.WriteLine($"Your Score: {earnedScore} / {totalScore}");

            // Calculate percentage
            double percentage = (double)earnedScore / totalScore * 100;
            Console.WriteLine($"Percentage: {percentage:F2}%");

            // Determine grade
            string grade;
            if (percentage >= 90)
                grade = "A (Excellent!)";
            else if (percentage >= 80)
                grade = "B (Very Good!)";
            else if (percentage >= 70)
                grade = "C (Good)";
            else if (percentage >= 60)
                grade = "D (Pass)";
            else
                grade = "F (Fail)";

            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}