// Generated by Fuzzlyn on 2018-06-25 13:25:09
// Seed: 1311689660153305265
// Reduced from 14.1 KiB to 0.3 KiB
// Debug: Outputs 154
// Release: Outputs -102
public class Program
{
    static sbyte[, ][,, ] s_1;
    public static void Main()
    {
        s_1 = new sbyte[, ][,, ]{{new sbyte[,, ]{{{-102}}}}};
        short vr7 = (byte)(s_1[0, 0][0, 0, 0] | 0U);
        System.Console.WriteLine(vr7);
    }
}