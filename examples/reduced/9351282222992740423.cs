// Generated by Fuzzlyn on 2018-06-19 17:14:21
// Seed: 9351282222992740423
// Reduced from 270.2 KiB to 0.4 KiB
// Debug: Outputs 247
// Release: Outputs 4294967287
class C0
{
    public sbyte F2;
    public C0(sbyte f2)
    {
        F2 = f2;
    }
}

public class Program
{
    static C0[] s_3;
    static C0[] s_33 = new C0[]{new C0(-10)};
    public static void Main()
    {
        s_3 = s_33;
        byte vr10 = (byte)(s_3[0].F2 ^ 1L);
        uint vr13 = vr10;
        System.Console.WriteLine(vr13);
    }
}