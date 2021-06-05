using System;
using System.Collections.Generic;
using RefazendoEnum1.Entities;
using RefazendoEnum1;

namespace RefazendoEnum1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

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
        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
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
               if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
               
            }
            return sum;
            {

            }
        }

    }

}
    
