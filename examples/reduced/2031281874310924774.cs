// Generated by Fuzzlyn on 2018-06-25 14:03:40
// Seed: 2031281874310924774
// Reduced from 68.8 KiB to 0.3 KiB
// Debug: Outputs 65430
// Release: Outputs 4294967190
public class Program
{
    static char s_20;
    static sbyte[, ] s_23 = new sbyte[, ]{{0}};
    public static void Main()
    {
        s_23[0, 0] = -106;
        char vr20 = (char)(s_23[0, 0] | s_20);
        long vr16 = vr20;
        System.Console.WriteLine(vr16);
    }
}