using System.Globalization;

namespace ExercicioFixacaoLista {
    class Emplyoee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Emplyoee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void SalaryIncrease(double perc) {
            double readjusment = perc * Salary;
            Salary +=readjusment;

        }
        public override string ToString() {
            return Id + ", " + Name + ", " + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
