// Generated by Fuzzlyn on 2018-06-19 04:21:40
// Seed: 845820792203145855
// Reduced from 217.8 KiB to 0.4 KiB
// Debug: Outputs 0
// Release: Outputs 243
struct S0
{
    public int F0;
}

struct S1
{
    public sbyte F0;
}

struct S2
{
    public byte F0;
    public S1 F1;
    public S0 F2;
}

public class Program
{
    static S2 s_25;
    public static void Main()
    {
        s_25.F1 = M5();
        System.Console.WriteLine(s_25.F2.F0);
    }

    static S1 M5()
    {
        return new S1();
    }
}