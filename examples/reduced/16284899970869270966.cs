// Generated by Fuzzlyn on 2018-06-25 13:43:50
// Seed: 16284899970869270966
// Reduced from 11.3 KiB to 0.3 KiB
// Debug: Outputs 65409
// Release: Outputs -127
public class Program
{
    static ushort s_2;
    static sbyte[, ][] s_3 = new sbyte[, ][]{{new sbyte[]{-127}}};
    public static void Main()
    {
        char vr18 = (char)(s_2 | s_3[0, 0][0]);
        int vr20 = vr18;
        System.Console.WriteLine(vr20);
    }
}
