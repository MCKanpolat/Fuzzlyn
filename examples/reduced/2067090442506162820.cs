// Generated by Fuzzlyn on 2018-06-25 11:56:39
// Seed: 2067090442506162820
// Reduced from 40.5 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[] s_1 = new sbyte[]{0};
    static ushort[, ] s_2 = new ushort[, ]{{0}};
    public static void Main()
    {
        ulong vr2 = (char)(0 % ((0 & s_2[0, 0]) | 1));
        sbyte vr3 = s_1[0];
    }
}
