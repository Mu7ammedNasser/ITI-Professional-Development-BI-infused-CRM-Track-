using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lab07
{
    internal class fileReader
    {
        public List<Question> ReadQuestions(string filePath)
        {
            List<Question> questions = new List<Question>();
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File Not Found in this path {filePath}");
                return questions;
            }
            // read all lines
            string[] allLines = File.ReadAllLines(filePath);
            Question? currentQuestion = null;
            for (int currentLine = 0; currentLine < allLines.Length; currentLine++)
            {
                string line = allLines[currentLine].Trim();

                if (string.IsNullOrEmpty(line))
                {
                    continue;

                }
                if (line.StartsWith("QUESTION_TYPE"))
                {
                    if (currentQuestion != null)
                    {
                        questions.Add(currentQuestion);
                    }

                    string type = line.Replace("QUESTION_TYPE:", "").Trim();
                    if (type == "MCQ")
                    {
                        currentQuestion = new MCQQuest();
                    }
                    else if (type == "TF")
                    {
                        currentQuestion = new TFQuest();
                    }
                    else
                    {
                        Console.WriteLine("in Valid Question Type");
                    }

                    currentQuestion.QuestType = (QuestType)Enum.Parse(typeof(QuestType), type!);
                }

                else if (line.StartsWith("QUESTION_ID"))
                {
                    currentQuestion.Id= int.Parse(line.Replace("QUESTION_ID:", "").Trim());
                }

                else if (line.StartsWith("QUESTION_TEXT"))
                {
                    currentQuestion.QBody = line.Replace("QUESTION_TEXT:", "").Trim();
                }

                else if (line.StartsWith("MARK"))
                {
                    currentQuestion.Mark = int.Parse(line.Replace("MARK:", "").Trim());
                }
                else if (line.StartsWith("CHOICE"))
                {
                    string choicePart = line.Replace("CHOICE:","").Trim();

                    string[] texrAndCorrector = choicePart.Split('|');

                    Choice choice = new Choice();

                    choice.choiceContent = texrAndCorrector[0];

                    choice.IsCorrect =  texrAndCorrector[1].ToUpper().Trim() == "TRUE";

                    currentQuestion.Choices.Add(choice);


                }else if (line.StartsWith("ANSWER"))
                {
                    currentQuestion.CorrectAnswer = line.Replace("ANSWER:", "").Trim();
                }


            }
                if (currentQuestion != null)
                {
                    questions.Add(currentQuestion);
                }
                return questions;
        }
    }
}
