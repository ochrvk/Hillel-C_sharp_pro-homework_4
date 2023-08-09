/*
    Створiть та опишiть клас «Співробітник». 

    Додайте до вже створеного класу інформацію про заробітну плату працівника. 

    Виконайте навантаження 

    + (для збільшення зарплати на вказану кількість), 

    – (для зменшення зарплати на вказану кількість), 

    == (перевірка на рівність зарплат працівників), 

    < і > (перевірка на меншу чи більшу кількість зарплат працівників), 

    != і Equals. Використовуйте механізм властивостей полів класу. 
 */




using Hillel_C_sharp_pro_homework_4;


List<Employee> employees = new List<Employee>(2);

for (int i = 0; i < 2; i++)
{
    employees.Add(new Employee());
    FillEmployee(employees[i], i + 1);
}

Console.Clear();



while (true)
{
    Console.WriteLine("Сhoose the option:");
    Console.WriteLine("+");
    Console.WriteLine("-");
    Console.WriteLine(">");
    Console.WriteLine("<");
    Console.WriteLine("==");
    Console.WriteLine("!=");
    Console.WriteLine("Equals");
    Console.WriteLine("0. Show employees");

    Console.Write(">>>");
    string option = Console.ReadLine();

    switch (option)
    {
        case "+":
            Add();
            break;
        case "-":
            Subtract();
            break;
        case ">":
            Console.WriteLine($"{employees[0].Name} > {employees[1].Name}: " +
                $"{employees[0] > employees[1]}");
            break;
        case "<":
            Console.WriteLine($"{employees[0].Name} < {employees[1].Name}: " +
                $"{employees[0] < employees[1]}");
            break;
        case "==":
            Console.WriteLine($"{employees[0].Name} == {employees[1].Name}: " +
                $"{employees[0] == employees[1]}");
            break;
        case "!=":
            Console.WriteLine($"{employees[0].Name} != {employees[1].Name}: " +
                $"{employees[0] != employees[1]}");
            break;
        case "Equals":
            Console.WriteLine($"Is {employees[0].Name} equal to {employees[1].Name}? " +
                $"- {employees[0].Equals(employees[1])}");
            break;
        case "0":
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }
            break;
        case "!q":
            return;
        default:
            Console.WriteLine("Wrong input! Please try again.");
            break;
    }
}





void Add()
{
    Console.Write("Enter value: ");
    uint value = 0;
    while (true)
    {
        try
        {

            value = uint.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.Write("Wrong value! Please try again: ");
        }
    }

    Console.Write("Select the employee for which you want to increase the salary: ");
    while (true)
    {
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                employees[0] = employees[0] + value;
                Console.WriteLine("Current salary: " + employees[0].Salary);
                return;
            case "2":
                employees[1] = employees[1] + value;
                Console.WriteLine("Current salary: " + employees[1].Salary);
                return;
            default:
                Console.Write("Wrong type. Please try again: ");
                break;
        }
    }
}

void Subtract()
{
    Console.Write("Enter value: ");
    uint value = 0;
    while (true)
    {
        try
        {

            value = uint.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.Write("Wrong value! Please try again: ");
        }
    }

    Console.Write("Select the employee for which you want to decrease the salary: ");
    while (true)
    {
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                employees[0] = employees[0] - value;
                Console.WriteLine("Current salary: " + employees[0].Salary);
                return;
            case "2":
                employees[1] = employees[1] - value;
                Console.WriteLine("Current salary: " + employees[1].Salary);
                return;
            default:
                Console.Write("Wrong type. Please try again: ");
                break;
        }
    }
}

void FillEmployee(Employee employee, int number)
{
    Console.Write($"Enter {number}_employee salary: ");
    while (true)
    {
        try
        {
            employee.Salary = decimal.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.Write("Wrong input! Please try again: ");
        }
    }


    Console.Write($"Enter {number}_employee age: ");
    while (true)
    {
        try
        {
            employee.Age = int.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.Write("Wrong input! Please try again: ");
        }
    }

    Console.Write($"Enter {number}_employee name: ");
    employee.Name = Console.ReadLine();

    Console.Write($"Enter {number}_employee position: ");
    while (true)
    {
        string employeePosti = Console.ReadLine();
        switch (employeePosti)
        {
            case "Director":
                employee.EmployeePosition = Position.Director;
                return;
            case "Manager":
                employee.EmployeePosition = Position.Manager;
                return;
            case "Employee":
                employee.EmployeePosition = Position.Employee;
                return;
            default:
                Console.Write("Wrong input! please try again: ");
                break;
        }
    }
}