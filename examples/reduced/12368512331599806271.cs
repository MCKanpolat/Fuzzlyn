// Generated by Fuzzlyn on 2018-06-20 19:05:11
// Seed: 12368512331599806271
// Reduced from 2.7 KiB to 0.4 KiB
// Debug: Outputs 26
// Release: Outputs -26854
struct S1
{
    public short F0;
    public int F1;
    public ushort F2;
    public ulong F3;
    public bool F4;
    public S1(int f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        S1 vr0 = new S1(-1037592806);
        short vr1 = (sbyte)vr0.F1;
        System.Console.WriteLine(vr1);
    }
}