// Generated by Fuzzlyn on 2018-06-21 14:00:32
// Seed: 3862140607048707260
// Reduced from 4.9 KiB to 0.3 KiB
// Debug: Outputs 32769
// Release: Outputs 4294934529
public class Program
{
    static short s_2 = 32767;
    public static void Main()
    {
        var vr11 = s_2++ & M4(M4(M4(M4((ushort)(1U ^ s_2)))));
    }

    static long M4(long arg0)
    {
        System.Console.WriteLine(arg0);
        return 0;
    }
}
