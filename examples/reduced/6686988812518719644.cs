// Generated by Fuzzlyn on 2018-06-21 09:39:53
// Seed: 6686988812518719644
// Reduced from 9.3 KiB to 0.3 KiB
// Debug: Outputs 65534
// Release: Outputs -2
struct S0
{
    public sbyte F0;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_1 = new S0(-2);
    public static void Main()
    {
        char vr0 = M1();
        System.Console.WriteLine((int)vr0);
    }

    static char M1()
    {
        return (char)(0 ^ s_1.F0);
    }
}