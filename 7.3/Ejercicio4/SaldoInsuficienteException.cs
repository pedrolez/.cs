class SaldoInsuficienteException : Exception

{
    public SaldoInsuficienteException(string message) : base(message) { }
    public SaldoInsuficienteException(string message, System.Exception inner) : base(message, inner) { }
}