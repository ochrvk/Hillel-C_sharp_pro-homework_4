namespace Hillel_C_sharp_pro_homework_4
{
    public class Employee
    {
        public Employee()
        {
            Name = "default_name";
            _salary = 0;
            EmployeePosition = Position.Empty;
            Age = 18;
        }

        private decimal _salary;

        private int _age;

        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18 || value > 60)
                {
                    throw new Exception("Incorrect age!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary cannot be assign by negative number");
                }
                else
                {
                    _salary = value;
                }
            }
        }

        public Position EmployeePosition { get; set; }

        public static Employee operator +(Employee employee, decimal amount)
        {
            employee.Salary += amount;
            return employee;
        }

        public static Employee operator -(Employee employee, decimal amount)
        {
            employee.Salary -= amount;
            return employee;
        }

        public static bool operator ==(Employee employee_1, Employee employee_2)
        {
            return employee_1.Salary == employee_2.Salary;
        }

        public static bool operator !=(Employee employee_1, Employee employee_2)
        {
            return employee_1.Salary != employee_2.Salary;
        }

        public static bool operator <(Employee employee_1, Employee employee_2)
        {
            return employee_1.Salary < employee_2.Salary;
        }

        public static bool operator >(Employee employee_1, Employee employee_2)
        {
            return employee_1.Salary > employee_2.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee other = (Employee)obj;
            return Name == other.Name && Salary == other.Salary && Age == other.Age
                && EmployeePosition == other.EmployeePosition;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nPosition: {EmployeePosition}\nSalary: {_salary}";
        }
    }
}
