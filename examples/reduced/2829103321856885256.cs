// Generated by Fuzzlyn on 2018-06-03 23:37:29
// Seed: 2829103321856885256
// Reduced from 24.4 KB to 0.2 KB
// Debug: Outputs 255
// Release: Outputs -1
public class Program
{
    static sbyte s_1 = 1;
    public static void Main()
    {
        sbyte vr59 = s_1--;
        sbyte vr69 = s_1--;
        var vr61 = vr69 + (byte)(0L | s_1);
        System.Console.WriteLine(vr61);
    }
}