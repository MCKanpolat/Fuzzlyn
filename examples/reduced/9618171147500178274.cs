// Generated by Fuzzlyn on 2018-06-25 11:12:44
// Seed: 9618171147500178274
// Reduced from 20.3 KiB to 0.4 KiB
// Debug: Outputs 129
// Release: Outputs -127
struct S0
{
    public uint F0;
    public sbyte F1;
    public char F2;
    public uint F3;
    public uint F4;
    public S0(sbyte f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr24 = new S0(-127);
        int vr25 = (byte)vr24.F1;
        System.Console.WriteLine(vr25);
    }
}