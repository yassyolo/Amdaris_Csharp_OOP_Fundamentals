namespace Assessment7.Exceptions
{
    internal class TooFastException : Exception
    {
        public TooFastException() { }

        public TooFastException(string message)
            : base(message) { }

        public TooFastException(string message, Exception inner)
            : base(message, inner) { }
    }
}
