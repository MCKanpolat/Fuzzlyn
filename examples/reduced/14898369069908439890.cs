// Generated by Fuzzlyn on 2018-06-25 07:40:13
// Seed: 14898369069908439890
// Reduced from 139.2 KiB to 0.5 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
struct S0
{
    public sbyte F0;
}

public class Program
{
    static short s_2;
    static sbyte s_3 = 126;
    static S0[][] s_6 = new S0[][]{new S0[]{new S0()}};
    static sbyte s_12;
    public static void Main()
    {
        var vr132 = s_3++;
        var vr133 = s_3++;
        s_6[0][0].F0 = s_3;
        sbyte vr134 = s_6[0][0].F0;
        s_12 = vr134;
        s_2 = s_12;
        var vr140 = (char)(0U | s_2);
        uint vr141 = vr140;
        System.Console.WriteLine(vr141);
    }
}