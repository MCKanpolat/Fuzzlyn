// Generated by Fuzzlyn on 2018-06-25 10:47:20
// Seed: 7760589428139151766
// Reduced from 227.9 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    public static void Main()
    {
        ulong vr2 = (char)(0 % ((0 & (-2147483648 / (0 - M1()))) | 1));
    }

    static byte M1()
    {
        long var0 = default(long);
        var vr0 = var0--;
        M2(var0);
        return 1;
    }

    static ushort M2(long arg0)
    {
        return 0;
    }
}
