namespace StacksAndQueuesLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(); 
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);      
            stack.Push(7);
            stack.Push(8);

            for(int i = 1; i < 9; i++) 
            {
               int peek =  stack.Peek();
                Console.WriteLine($"{peek}");
                stack.Pop();
            }
        }
    }
}