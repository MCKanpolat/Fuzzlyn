// Generated by Fuzzlyn on 2018-06-25 14:26:07
// Seed: 5087042132207794337
// Reduced from 143.4 KiB to 0.3 KiB
// Debug: Outputs 65529
// Release: Outputs -7
public class Program
{
    static sbyte[][, ] s_5 = new sbyte[][, ]{new sbyte[, ]{{-7}}};
    static ushort s_16;
    public static void Main()
    {
        var vr26 = (char)(s_16 | s_5[0][0, 0]);
        System.Console.WriteLine((int)vr26);
    }
}
