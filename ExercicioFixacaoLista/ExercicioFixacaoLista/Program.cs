using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoLista {
    class Program {
        static void Main(string[] args) {

           

            List<Emplyoee> list = new List<Emplyoee>();

            Console.Write(" How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

       

            for (int i = 1; i <= n; i++) {
                
                Console.WriteLine($"Emplyoee #{i}:" );

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Emplyoee(id, name, salary));

                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Emplyoee emp = list.Find(x => x.Id == searchId); //x.Id: chamar na memória do id
            // esse objeto foi chamado a fim de que o elemento x seja tal que chame na memória do Id e seja igual a serachId

            if (emp != null) {

                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.SalaryIncrease(percentage);



            } else {

                Console.WriteLine("This id does not exist!");

            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");

            foreach(Emplyoee obj in list) {
                Console.WriteLine(obj);
            }


        }
    }
}
