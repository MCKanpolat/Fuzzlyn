// Generated by Fuzzlyn on 2018-06-19 13:46:32
// Seed: 12723018618115625256
// Reduced from 0.7 KiB to 0.2 KiB
// Debug: Outputs 35391
// Release: Outputs -30145
public class Program
{
    public static void Main()
    {
        var vr1 = new short[]{-30145};
        char vr3 = (char)(vr1[0] | 0U);
        System.Console.WriteLine((int)vr3);
    }
}