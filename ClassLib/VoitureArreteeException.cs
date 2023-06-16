using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class VoitureArreteeException : ArgumentException
    {
        public VoitureArreteeException(){;}

        public VoitureArreteeException(string message):base(message){;}

        public VoitureArreteeException(string message, Exception innerException): base(message, innerException){;}
    }
}
