using System;

class Stack
{
    private int[] stack = new int[10];
    private int sp = 0;

    public void Push(int v)
    {
        stack[sp++] = v;
        //stack[sp] = v;
        //sp = sp + 1;
    }

    public int Pop() //method that returns an integer value off of a stack
    {
        return stack[--sp];
        //sp = sp - 1;
        //return stack [sp];
    }

    public int Top //property
    {
        get
        {
            return stack[sp - 1];
        }
    }

    public bool IsEmpty
    {
        get
        {
            return sp == 0;
            //Return true if sp is at zero
        }
    }
}

class Arrays_Stacks
{
    static void Main()
    {
        var stack = new Stack();

        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);

        Console.WriteLine("The last value pushed was {0}", stack.Top);

        while (!stack.IsEmpty)
        {
            Console.WriteLine("Popping {0}", stack.Pop());
        }

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}