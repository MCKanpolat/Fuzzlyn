// Generated by Fuzzlyn on 2018-06-25 14:21:55
// Seed: 4394918795785398897
// Reduced from 56.5 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    public static void Main()
    {
        var vr24 = new uint[][, ]{new uint[, ]{{0}}};
        M9(vr24);
    }

    static long M9(uint[][, ] arg2)
    {
        var vr10 = arg2[0][0, 0] & 0;
        System.Console.WriteLine(0);
        var vr33 = arg2[0][0, 0];
        System.Console.WriteLine(vr10);
        return 0;
    }
}
