// Generated by Fuzzlyn on 2018-06-25 15:05:30
// Seed: 9521405761135830270
// Reduced from 49.8 KiB to 0.5 KiB
// Debug: Outputs -55
// Release: Outputs -127
class C0
{
    public byte F2;
    public sbyte F5;
    public C0(byte f2, sbyte f5)
    {
        F2 = f2;
        F5 = f5;
    }
}

struct S1
{
    public C0 F2;
    public S1(C0 f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static S1 s_1;
    public static void Main()
    {
        s_1 = new S1(new C0(247, -127));
        ushort vr86 = 0;
        sbyte vr45 = (sbyte)((ushort)((vr86 | 1) | s_1.F2.F5) % s_1.F2.F2);
        System.Console.WriteLine(vr45);
    }
}
