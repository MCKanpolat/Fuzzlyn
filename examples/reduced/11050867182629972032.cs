// Generated by Fuzzlyn on 2018-06-23 06:40:49
// Seed: 11050867182629972032
// Reduced from 75.5 KiB to 0.3 KiB
// Debug: Outputs 65469
// Release: Outputs 4294967229
struct S0
{
    public long F7;
    public sbyte F9;
    public S0(sbyte f9): this()
    {
        F9 = f9;
    }
}

public class Program
{
    static S0 s_1 = new S0(-67);
    static uint s_2;
    public static void Main()
    {
        s_2 = (ushort)(s_1.F9 | (byte)(s_1.F7 ^ 0));
        System.Console.WriteLine(s_2);
    }
}
