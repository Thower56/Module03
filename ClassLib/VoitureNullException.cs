using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class VoitureNullException : NullReferenceException
    {
        public VoitureNullException(){;}

        public VoitureNullException(string message):base(message){;}

        public VoitureNullException(string message, Exception innerException): base(message, innerException){;}
    }
}