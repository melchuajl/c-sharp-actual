namespace ExceptionHandling
{
    internal class ExceptionDemo : Exception
    {
        // one version of the constructor
        public ExceptionDemo() { }
        // another version of the constructor that takes params
        public ExceptionDemo(string message) : base(message) { } // we are calling the constructor of the base class (Exception), which will run in its derived classes 
    }
}
