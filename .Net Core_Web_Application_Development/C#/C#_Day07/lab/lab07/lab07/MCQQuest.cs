using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    internal class MCQQuest : Question
    {
        public MCQQuest()
        {
            Choices = new List<Choice>();
        }
        public override void DisplayQues(bool isPracticeExam)
        {
            Console.Clear();
            Console.WriteLine($"\nQuestion {Id}: {QBody}");
            Console.WriteLine($"Type: Multiple Choice | Marks: {Mark}");
            Console.WriteLine("Choices:");

            if (Choices != null && Choices.Count > 0)
            {
                for (int i = 0; i < Choices.Count; i++)
                {
                    Console.WriteLine($"  {(char)('A' + i)}. {Choices[i].choiceContent}");
                }
            }
            Console.WriteLine();

            getStudentAnswers();

            if (isPracticeExam)
            {
                // Practice exam: show answer
                Console.WriteLine("\nCorrect Answer:");
                foreach (var item in Choices)
                {
                    if (item.IsCorrect)
                        Console.WriteLine(item.choiceContent);
                }

                // Check if student was correct
                bool isCorrect = storeStudentAnswer();
                if (isCorrect)
                {
                    Console.WriteLine("Your answer is Correct!");
                }
                else
                {
                    Console.WriteLine("Your answer is Wrong!");
                }

                Console.WriteLine("\nPress Enter to go to next question");
                Console.ReadLine();
            }
            else
            {
                // Final exam: store answer
                storeStudentAnswer();
                Console.WriteLine("Answer recorded.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        public override void getStudentAnswers()
        {
            int numberOfChoices = Choices.Count();
            if (numberOfChoices == 2)
            {
                Console.WriteLine("Enter your answer (A or B)");
                while (true)
                {
                    string? choice = Console.ReadLine()?.ToUpper().Trim();
                    if (choice == "A" | choice == "B")
                        return;

                    Console.WriteLine("Enter Valid Answer!");

                }
            }
            else if (numberOfChoices == 3)
            {
                Console.WriteLine("Enter your answer (A, B or C)");
                while (true)
                {
                    string? choice = Console.ReadLine()?.ToUpper().Trim();
                    if (choice == "A" | choice == "B" | choice == "C")
                        return;
                    Console.WriteLine("Enter Valid Answer!");
                }
            }
            else if (numberOfChoices == 4)
            {
                Console.WriteLine("Enter your answer (A, B, C or D )");
                string? choice = Console.ReadLine()?.ToUpper().Trim();
                while (true)
                {
                    if (choice == "A" | choice == "B" | choice == "C" | choice == "D")
                        return;
                    Console.WriteLine("Enter Valid Answer!");

                }

            }
        }

        public override bool storeStudentAnswer()
        {
            return true;
        }

    }
}
