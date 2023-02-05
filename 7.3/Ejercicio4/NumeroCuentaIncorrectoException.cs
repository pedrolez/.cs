class NumeroCuentaIncorrectoException : Exception
{
    public NumeroCuentaIncorrectoException(string message) : base(message) 
    { 

    }
    public NumeroCuentaIncorrectoException(string message, Exception inner) : base(message, inner)
     {

     }
    
}