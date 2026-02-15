using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    internal class TFQuest : Question
    {
        public TFQuest()
        {
            Choices = new List<Choice>();
        }

        public override void DisplayQues(bool isPracticeExam)
        {
            Console.Clear();
            Console.WriteLine($"\nQuestion {Id}: {QBody}");
            Console.WriteLine($"Type: True/False | Marks: {Mark}");
            Console.WriteLine("A. True");
            Console.WriteLine("B. False");
            Console.WriteLine();

            getStudentAnswers();

            if (isPracticeExam)
            {
                Console.WriteLine("\nCorrect Answer:");

                if (CorrectAnswer != null)
                {
                    Console.WriteLine(CorrectAnswer);
                }

                bool isCorrect = storeStudentAnswer();
                if (isCorrect)
                {
                    Console.WriteLine("Your answer is Correct!");
                }
                else
                {
                    Console.WriteLine("Your answer is Wrong!");
                }

                Console.WriteLine($"You answered: {(userAnswer == "A" ? "True" : "False")}");
                Console.WriteLine("\nPress Enter to go to next question");
                Console.ReadLine();
            }
            else
            {
                storeStudentAnswer();
                Console.WriteLine("Answer recorded.");
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        public override void getStudentAnswers()
        {
            Console.Write("Enter your answer (A for True, B for False): ");

            while (true)
            {
                string? choice = Console.ReadLine()?.ToUpper().Trim();

                if (choice == "A" || choice == "B")
                {
                    userAnswer = choice;  
                    return;
                }

                Console.Write("Enter Valid Answer (A or B): ");
            }
        }

        public override bool storeStudentAnswer()
        {
            if (string.IsNullOrEmpty(userAnswer) || string.IsNullOrEmpty(CorrectAnswer))
                return false;

           
            string userAnswerText = userAnswer == "A" ? "True" : "False";

            return userAnswerText.Equals(CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }
}