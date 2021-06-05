using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixEnum.Entities
{
    class Clients
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Clients()
        {

        }

        public Clients(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return "Client: "+
            Name+
            " "+
            BirthDate+
            " - "+
            Email ;
        }
    }
}
