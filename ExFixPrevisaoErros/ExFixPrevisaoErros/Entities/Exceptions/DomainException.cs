using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixPrevisaoErros.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mesage) : base(mesage)
        {

        }
    }
}
