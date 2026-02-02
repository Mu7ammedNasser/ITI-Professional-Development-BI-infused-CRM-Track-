namespace lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array of employees
            Employee[] employees;
            Console.WriteLine("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());
            employees = new Employee[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Enter data for employee {i + 1}:");
                Employee emp = new Employee();
                Console.WriteLine("Enter id");
                emp.SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter name");
                emp.SetName(Console.ReadLine());
                Console.WriteLine("Enter age");
                emp.SetAge(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter salary");
                emp.SetSalary(double.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Gender");
                var resG = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);
                emp.SetGender(resG);
                Console.WriteLine("Enter Security Level");
                var scl = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine(), true);
                emp.SetSecurityLevel(scl);
                HiringDate hd = new HiringDate();
                Console.WriteLine("Enter day of HiringDate");
                hd.SetDay(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter month");
                hd.SetMonth(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter year");
                hd.SetYear(int.Parse(Console.ReadLine()));

                emp.SetHiringDate(hd);
                employees[i] = emp;
            }
            Console.WriteLine("Employee Details:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(employees[i].Print());
            }
            #endregion


            
        }
    }
}

