// Generated by Fuzzlyn on 2018-06-25 13:58:18
// Seed: 17885871570980284875
// Reduced from 12.7 KiB to 0.2 KiB
// Debug: Outputs 164
// Release: Outputs -92
public class Program
{
    static sbyte s_1 = -92;
    public static void Main()
    {
        uint vr3 = default(uint);
        var vr4 = (byte)(s_1 + vr3);
        System.Console.WriteLine((int)vr4);
    }
}