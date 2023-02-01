 class ParametroNoValidoException : Exception
    {
        public ParametroNoValidoException()
        {
        }

        public ParametroNoValidoException(string message) : base(message)
        {
        }
    }