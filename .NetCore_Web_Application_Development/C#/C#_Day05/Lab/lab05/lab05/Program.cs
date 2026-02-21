namespace lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ArrayOfEmp
            //Employee[] employee = new Employee[3];
            //employee[0] = new Employee(1, "Amr", 22, 30000, new HiringDate(24, 9, 2002), Gender.M, SecurityLevel.DBA);
            //employee[1] = new Employee(2, "Basel", 22, 30000, new HiringDate(24, 9, 2002), Gender.F, SecurityLevel.dev);
            //employee[2] = new Employee(3, "Abbasy", 22, 30000, new HiringDate(24, 9, 2002), Gender.M, SecurityLevel.Admin );

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(employee[i]);
            //}
            #endregion

            #region Singletone

            NIC card = NIC.nIC;
            NIC card2 = NIC.nIC;

            Console.WriteLine(object.ReferenceEquals(card , card2));

            #endregion


            //Duration duration = new Duration(3663);
            //Duration duration2 = new Duration(5000);

            //Console.WriteLine(duration + 5000);
            //Console.WriteLine( 5000 + duration);

            //Console.WriteLine(duration++);
            //Console.WriteLine(duration--);

            //Console.WriteLine(duration >duration2);

        }
    }
}
