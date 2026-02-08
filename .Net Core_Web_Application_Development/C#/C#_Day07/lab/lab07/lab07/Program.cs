namespace lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examination system");

            string exeFolder = AppContext.BaseDirectory;           // folder of the .exe
            string filePath = Path.Combine(exeFolder, "QDB.txt");

            fileReader reader = new fileReader();
            List<Question> questions = reader.ReadQuestions(filePath);

            Console.WriteLine("=== Loaded " + questions.Count + " questions ===\n");

      

        }
    }
}
