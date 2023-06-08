Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

Console.WriteLine("Текущий стек:");
while (!stack.IsEmpty())
{
    int item = stack.Pop();
    Console.WriteLine(item);
}