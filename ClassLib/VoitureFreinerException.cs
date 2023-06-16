using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class VoitureFreinerException : ArgumentException
    {
        public VoitureFreinerException(){;}

        public VoitureFreinerException(string message):base(message){;}

        public VoitureFreinerException(string message, Exception innerException): base(message, innerException){;}
    }
}