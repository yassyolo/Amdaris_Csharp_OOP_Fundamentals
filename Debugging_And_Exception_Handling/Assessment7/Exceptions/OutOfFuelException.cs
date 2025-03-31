namespace Assessment7.Exceptions
{
    internal class OutOfFuelException : Exception
    {
        public OutOfFuelException() { }

        public OutOfFuelException(string message)
            : base(message) { }
    }
}
