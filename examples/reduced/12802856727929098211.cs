// Generated by Fuzzlyn on 2018-06-19 19:18:40
// Seed: 12802856727929098211
// Reduced from 15.5 KiB to 0.5 KiB
// Debug: Outputs 0
// Release: Outputs -2
struct S0
{
    public sbyte F0;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F1;
    public S0 F2;
    public S1(S0 f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static S1 s_3;
    public static void Main()
    {
        var vr1 = new S1[]{new S1(new S0(-2))};
        s_3.F1 = M1(vr1);
        System.Console.WriteLine(s_3.F2.F0);
    }

    static S0 M1(S1[] arg0)
    {
        return arg0[0].F1;
    }
}