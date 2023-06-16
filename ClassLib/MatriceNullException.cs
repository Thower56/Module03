namespace ClassLib
{
    public class MatriceNullException : NullReferenceException
    {
        public MatriceNullException(){;}

        public MatriceNullException(string message):base(message){;}

        public MatriceNullException(string message, Exception innerException): base(message, innerException){;}
    }
}