using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class VoitureAccelererException : ArgumentException
    {
        public VoitureAccelererException(){;}

        public VoitureAccelererException(string message):base(message){;}

        public VoitureAccelererException(string message, Exception innerException): base(message, innerException){;}
    }
}