// Generated by Fuzzlyn on 2018-06-25 13:39:02
// Seed: 15242310615267493544
// Reduced from 47.8 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_2 = new sbyte[, ]{{0}};
    public static void Main()
    {
        var vr30 = (short)((0 & s_2[0, 0]) + s_2[0, 0]);
        M19(vr30);
    }

    static short[] M19(short arg1)
    {
        return new short[]{0, 0, 0, 0, 0, 3159, 23496, 0, 0, 0};
    }
}
