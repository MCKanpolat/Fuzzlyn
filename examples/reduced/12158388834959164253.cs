// Generated by Fuzzlyn on 2018-06-25 13:18:29
// Seed: 12158388834959164253
// Reduced from 44.3 KiB to 0.3 KiB
// Debug: Outputs -77
// Release: Outputs 1
public class Program
{
    static sbyte s_4 = -77;
    public static void Main()
    {
        bool vr24 = '|' > (byte)(s_4 | 0L);
        if (vr24)
        {
            s_4 /= -65;
        }
        else
        {
        }

        System.Console.WriteLine((int)s_4);
    }
}
