using System;


namespace Stack
{
    public class StackOverflowException : Exception
    {
        public StackOverflowException(string Message = "Stack Overflow") : base(Message)
        {
            
        }

        public StackOverflowException(Exception Inner, string Message = "Stack Overflow") : base(Message, Inner)
        {
            
        }
    }
}