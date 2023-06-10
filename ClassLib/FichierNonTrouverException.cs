using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
    public class FichierNonTrouverException: FileNotFoundException
    {
        public FichierNonTrouverException(){;}

        public FichierNonTrouverException(string message): base(message) {;}

        public FichierNonTrouverException(string message, Exception innerException): base(message, innerException) {;}

    }

}