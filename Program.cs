using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(10);
            
            stack.AddToStack(Value: 1);
            stack.AddToStack(Value: 2);
            stack.AddToStack(Value: 3);
            stack.AddToStack(Value: 4);
            stack.AddToStack(Value: 5);
            stack.AddToStack(Value: 6);
            stack.AddToStack(Value: 7);
            stack.AddToStack(Value: 8);
            stack.AddToStack(Value: 9);
            stack.AddToStack(Value: 10);
            stack.PeekStack();
            
            Console.WriteLine(stack.RemoveFromStack());
            
            stack.AddToStack(11);

            Console.ReadKey();
        }
    }
}