namespace CompanyRoster
{
    class CompanyRoster
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> departmentsSalaries = new Dictionary<string, List<double>>();
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                double salary = Convert.ToDouble(input[1]);
                string department = input[2];

                Employee employeee = new Employee(name, salary, department);
                if (!employees.Contains(employeee))
                {
                    employees.Add(employeee);
                }

                foreach (var employee in employees)
                {
                    if (!departmentsSalaries.ContainsKey(employee.Department))
                    {
                        departmentsSalaries.Add(employee.Department, new List<double>());
                    }
                    departmentsSalaries[employee.Department].Add(employee.Salary);
                }
            }
            double highestAverageSalary = Double.MinValue;
            string highestAverageSalaryDepartment = null;

            foreach (var dept in departmentsSalaries)
            {
                double deptAvrgSalary = dept.Value.Average();
                if (deptAvrgSalary > highestAverageSalary)
                {
                    highestAverageSalary = deptAvrgSalary;
                    highestAverageSalaryDepartment = dept.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment}");
            foreach (var employee in employees.OrderByDescending(x => x.Salary))
            {
                if (employee.Department == highestAverageSalaryDepartment)
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                }
            }
        }
    }
}