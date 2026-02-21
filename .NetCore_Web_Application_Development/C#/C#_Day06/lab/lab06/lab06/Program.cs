namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = {
                 new Employee(
        1,
        "Nasser",
        22,
        30000,
        new HiringDate(10, 5, 2021),
        Gender.M,
        SecurityLevel.DBA
    ),

    new Employee(
        2,
        "Ahmed",
        25,
        28000,
        new HiringDate(3, 8, 2019),
        Gender.M,
        SecurityLevel.Guest
    ),

    new Employee(
        3,
        "Sara",
        24,
        32000,
        new HiringDate(15, 2, 2022),
        Gender.F,
        SecurityLevel.Guest
    ),

    new Employee(
        4,
        "Mona",
        27,
        35000,
        new HiringDate(1, 1, 2018),
        Gender.F,
        SecurityLevel.Guest
    )
                };

            Array.Sort( employees );

            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
