using System;
using System.Collections.Generic;
using System.Text;

namespace LoaBarracks.Infra.Exceptions
{
    public class ObserverErrorException : Exception
    {
        public ObserverErrorException(string message) : base(message)
        {
        }

        public ObserverErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
