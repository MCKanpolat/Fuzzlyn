// Generated by Fuzzlyn on 2018-06-25 14:34:44
// Seed: 6546835336132909277
// Reduced from 115.1 KiB to 0.2 KiB
// Debug: Outputs 255
// Release: Outputs -1
public class Program
{
    static sbyte s_36 = -2;
    public static void Main()
    {
        var vr3 = (byte)(s_36 ^ 1U);
        int vr4 = vr3;
        System.Console.WriteLine(vr4);
    }
}
