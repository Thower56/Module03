using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class VoitureDemarreException : ArgumentException
    {
        public VoitureDemarreException(){;}

        public VoitureDemarreException(string message):base(message){;}

        public VoitureDemarreException(string message, Exception innerException): base(message, innerException){;}
    }
}