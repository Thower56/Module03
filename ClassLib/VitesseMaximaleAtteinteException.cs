using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class VitesseMaximaleAtteinteException : ArgumentOutOfRangeException
    {
        public VitesseMaximaleAtteinteException(){;}

        public VitesseMaximaleAtteinteException(string message):base(message){;}

        public VitesseMaximaleAtteinteException(string message, Exception innerException): base(message, innerException){;}
    }
}