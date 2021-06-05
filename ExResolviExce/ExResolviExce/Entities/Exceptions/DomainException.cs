using System;


namespace ExResolviExce.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mesage) : base(mesage)
        {

        }
    }
}
