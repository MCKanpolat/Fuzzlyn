// Generated by Fuzzlyn on 2018-06-25 13:28:02
// Seed: 1374585756289470858
// Reduced from 131.1 KiB to 0.3 KiB
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
public class Program
{
    static sbyte[, ] s_18 = new sbyte[, ]{{-40}};
    static int s_23;
    public static void Main()
    {
        int vr6 = default(int);
        bool vr7 = (ushort)(s_18[0, 0] ^ 0) > s_23;
        if (vr7)
        {
            System.Console.WriteLine(vr6);
        }
        else
        {
        }
    }
}