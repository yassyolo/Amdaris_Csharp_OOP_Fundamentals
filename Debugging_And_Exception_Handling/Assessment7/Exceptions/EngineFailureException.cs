namespace Assessment7.Exceptions
{
    internal class EngineFailureException : Exception
    {
        public EngineFailureException() { }

        public EngineFailureException(string message)
            : base(message) { }
    }
}
