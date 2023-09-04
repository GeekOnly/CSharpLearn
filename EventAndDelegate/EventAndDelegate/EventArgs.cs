using System;
public class ExampleClass
{

    public delegate void DoSomething(int num);

    public DoSomething Something;

    public ExampleClass()
    {
        Something = FunctionOne;

        Something?.Invoke(123);

        Something = FunctionTwo;

        Something?.Invoke(987);
    }

    private void FunctionTwo(int num)
    {
        Console.WriteLine($"Function two called with value: {num}");
    }
    private void FunctionOne(int num)
    {
        Console.WriteLine($"Function two called with value: {num}");
    }
}