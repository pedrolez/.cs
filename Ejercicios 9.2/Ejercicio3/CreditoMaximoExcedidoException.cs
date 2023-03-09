class CreditoMaximoExcedidoException : Exception
{
    public CreditoMaximoExcedidoException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}