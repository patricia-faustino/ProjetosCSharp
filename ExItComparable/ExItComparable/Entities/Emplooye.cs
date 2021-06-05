using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExItComparable.Entities
{
    class Emplooye : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Emplooye(string csvEmplooye)
        {
            string[] vect = csvEmplooye.Split(" , ");
            Name = vect[0];
            Salary =double.Parse(vect[1],CultureInfo.InvariantCulture);      
        }

        public override string ToString()
        {
            return Name+ ", "
                +Salary.ToString("F2",CultureInfo.InvariantCulture);
        }

        //Proteger argumentação
        public int CompareTo(object obj)
        {
          if(!(obj is Emplooye))
            {
                throw new ArgumentException("Comparing error: argument is no Emplooye");
            }
            Emplooye other = obj as Emplooye;
            return Name.CompareTo(other.Name);
        }
    }
}
