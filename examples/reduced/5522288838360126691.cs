// Generated by Fuzzlyn on 2018-06-25 13:09:50
// Seed: 5522288838360126691
// Reduced from 69.1 KiB to 0.2 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    public static void Main()
    {
        M1(-127);
    }

    static ulong M1(sbyte arg0)
    {
        var vr2 = 0 / ((0 & (-9223372036854775808L % (arg0 / 'v'))) | 1);
        return 0;
    }
}