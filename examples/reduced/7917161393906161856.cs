// Generated by Fuzzlyn on 2018-06-21 23:41:06
// Seed: 7917161393906161856
// Reduced from 243.1 KiB to 0.4 KiB
// Debug: Outputs -19
// Release: Outputs 237
struct S0
{
    public sbyte F0;
    public long F1;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0[] s_2 = new S0[]{new S0(0)};
    public static void Main()
    {
        s_2[0] = new S0(-19);
        S0 vr1 = s_2[0];
        char vr2 = (char)(byte)(vr1.F1 ^ s_2[0].F0);
        System.Console.WriteLine(vr1.F0);
        System.Console.WriteLine((int)vr2);
    }
}