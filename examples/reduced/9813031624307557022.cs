// Generated by Fuzzlyn on 2018-06-25 15:08:21
// Seed: 9813031624307557022
// Reduced from 127.8 KiB to 0.3 KiB
// Debug: Outputs 65527
// Release: Outputs -9
public class Program
{
    static sbyte s_1 = -10;
    static char s_37;
    static short s_57;
    public static void Main()
    {
        s_57 = (short)M7();
    }

    static char M7()
    {
        int vr102 = (char)((char)(1UL ^ (uint)(0 / ((0 & s_1) | 1))) | s_1);
        System.Console.WriteLine(vr102);
        return s_37;
    }
}
