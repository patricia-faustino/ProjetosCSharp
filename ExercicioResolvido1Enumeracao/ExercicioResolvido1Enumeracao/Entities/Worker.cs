using ExercicioResolvido1Enumeracao.Entities.Enums;
using System.Collections.Generic;

namespace ExercicioResolvido1Enumeracao.Entities
{
    class Worker
    {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //  associacao entre duas classes distintas
        public List<HourContract> Contract { get; set; } = new List<HourContract>();
        // tem que criar a lista, pois há a possiblidade de vários contratos
        //instanciar para garantir que a Lista não seja vazia

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            Contract = new List<HourContract>();
        }
        // Nao eh usual colocar uma lista num construtor, pois ela ja inicia vazia e sempre que tiver uma iniciacao para muitos
        //nao inclui ela no construtor

        public void AddContract(HourContract contract)
        {
            Contract.Add(contract); // chama a lista Contract que vai adicionar o parametro de entrada contract
        }
        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contract)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();// .TotalValue() : retorna o valor total do contrato
                }
            }
            return sum;
        }
    }

}

    
