using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using ExFixacao.Entities;

namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double entSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {

                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }


                var emails = list.Where(obj => obj.Salary > entSalary).OrderBy(obj => obj.Email).Select(obj => obj.Email);

                Console.WriteLine("Email of people whose salary is more than " + entSalary.ToString("F2", CultureInfo.InvariantCulture) + ":");

                foreach (string em in emails)
                {
                    Console.WriteLine(em);
                }

                Console.Write("Sum of salary of people whose name starts with 'M': ");
                var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);
                Console.WriteLine(sum);
            } 
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            


        }
    }
}

