// Generated by Fuzzlyn on 2018-06-21 19:32:01
// Seed: 13375745288687492645
// Reduced from 2.8 KiB to 0.4 KiB
// Debug: Outputs 28303
// Release: Outputs -119378289
struct S0
{
    public uint F1;
    public short F2;
    public char F3;
    public short F4;
    public short F5;
    public S0(uint f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr3 = new S0(4175589007U);
        char vr4 = (char)vr3.F1;
        System.Console.WriteLine((int)vr4);
    }
}