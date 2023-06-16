namespace ClassLib
{
    public class MatriceDimensionIncompatibleException : ArgumentOutOfRangeException
    {
        public MatriceDimensionIncompatibleException(){;}

        public MatriceDimensionIncompatibleException(string message):base(message){;}

        public MatriceDimensionIncompatibleException(string message, Exception innerException): base(message, innerException){;}
    }

    public class MatriceIdentiteArgumentException : ArgumentException
    {
        public MatriceIdentiteArgumentException(){;}

        public MatriceIdentiteArgumentException(string message):base(message){;}

        public MatriceIdentiteArgumentException(string message, Exception innerException): base(message, innerException){;}
    }

    public class MatricesCtorParameterArgumentException : ArgumentException
    {
        public MatricesCtorParameterArgumentException(){;}

        public MatricesCtorParameterArgumentException(string message):base(message){;}

        public MatricesCtorParameterArgumentException(string message, Exception innerException): base(message, innerException){;}
    }

    public class MatricesCtorParameterNullException : ArgumentNullException
    {
        public MatricesCtorParameterNullException(){;}

        public MatricesCtorParameterNullException(string message):base(message){;}

        public MatricesCtorParameterNullException(string message, Exception innerException): base(message, innerException){;}
    }

    public class MatriceTransposeArgumentsException : ArgumentException
    {
        public MatriceTransposeArgumentsException(){;}

        public MatriceTransposeArgumentsException(string message):base(message){;}

        public MatriceTransposeArgumentsException(string message, Exception innerException): base(message, innerException){;}
    }

    public class MatriceTransposeNullArgumentsException : ArgumentNullException
    {
        public MatriceTransposeNullArgumentsException(){;}

        public MatriceTransposeNullArgumentsException(string message):base(message){;}

        public MatriceTransposeNullArgumentsException(string message, Exception innerException): base(message, innerException){;}
    }
}