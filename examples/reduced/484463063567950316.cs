// Generated by Fuzzlyn on 2018-06-19 23:30:40
// Seed: 484463063567950316
// Reduced from 63.2 KiB to 0.2 KiB
// Debug: Outputs 249
// Release: Outputs 4294967289
public class Program
{
    static sbyte s_1 = -7;
    public static void Main()
    {
        byte vr26 = (byte)(s_1 / (long)1);
        long vr27 = vr26;
        System.Console.WriteLine(vr27);
    }
}