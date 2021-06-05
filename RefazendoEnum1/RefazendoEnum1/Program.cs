using System;
using System.Globalization;
using RefazendoEnum1.Entities;
namespace RefazendoEnum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            for(int i =1; i <=n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hour);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string yearmonth = Console.ReadLine();
            int month = int.Parse(yearmonth.Substring(0, 2));
            int year = int.Parse(yearmonth.Substring(3));
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Department: "+deptName);
            worker.Income(year, month);
            Console.WriteLine("Income for "+yearmonth+": "+worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
