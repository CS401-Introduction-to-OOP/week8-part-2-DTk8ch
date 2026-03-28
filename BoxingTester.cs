namespace Variant2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;

        object b = a; // boxing
        int c = (int)b; // unboxing

        Console.WriteLine("Boxing test:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");

        // a is value type
        // b stores boxed copy of a in heap
        // c gets value back after unboxing
    }
}
