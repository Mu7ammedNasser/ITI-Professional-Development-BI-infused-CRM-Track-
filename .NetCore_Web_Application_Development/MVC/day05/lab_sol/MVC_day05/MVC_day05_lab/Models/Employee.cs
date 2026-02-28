namespace MVC_day05_lab.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
