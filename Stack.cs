namespace Stack
{
    public class Stack<T>
    {
        private int MAXSIZE;
        private int StackPointerPos = -1;
        private T[] StackObj;
        
        public Stack(int MaxSize)
        {
            this.MAXSIZE = MaxSize;
            this.StackObj = new T[this.MAXSIZE];
        }

        public void AddToStack(T Value)
        {
            if (StackPointerPos + 1 == MAXSIZE)
            {
                throw new StackOverflowException();
            }
            
            StackPointerPos++;
            StackObj[StackPointerPos] = Value;
        }

        public T RemoveFromStack()
        {
            T value = StackObj[StackPointerPos];
            
            StackObj.SetValue(value: null, StackPointerPos);

            StackPointerPos--;

            return value;
        }

        public T PeekStack()
        {
            return StackObj[StackPointerPos];
        }
    }
}