// Generated by Fuzzlyn on 2018-06-20 07:20:02
// Seed: 15899317618850414970
// Reduced from 37.7 KiB to 0.7 KiB
// Debug: 
// Release: 
struct S0
{
    public char F0;
    public sbyte F1;
    public char F2;
    public S0(sbyte f1): this()
    {
    }
}

struct S1
{
    public S0 F2;
    public sbyte F3;
}

struct S2
{
    public long F1;
    public S1 F4;
    public S1 F9;
}

public class Program
{
    static uint s_1;
    static S2 s_7;
    public static void Main()
    {
        s_1 = M4(s_7, new ulong[][]{new ulong[]{0}});
        s_7.F4.F2 = M19();
        char vr34 = s_7.F4.F2.F2;
        S2 vr36 = s_7;
        System.Console.WriteLine(vr36.F4.F3);
    }

    static ushort M4(S2 arg2, ulong[][] arg3)
    {
        System.Console.WriteLine(arg2.F4.F3);
        return 0;
    }

    static S0 M19()
    {
        return new S0(0);
    }
}