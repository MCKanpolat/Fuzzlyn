// Generated by Fuzzlyn on 2018-06-24 18:31:26
// Seed: 16259859392050433165
// Reduced from 23.6 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static byte[, ] s_1 = new byte[, ]{{0}};
    public static void Main()
    {
        long vr4 = (0 & s_1[0, 0]) % (s_1[0, 0] | 1);
    }
}