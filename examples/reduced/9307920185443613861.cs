// Generated by Fuzzlyn on 2018-06-25 15:03:38
// Seed: 9307920185443613861
// Reduced from 35.6 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static int[, ] s_20 = new int[, ]{{0}};
    public static void Main()
    {
        byte vr0 = (byte)(0 & s_20[0, 0]);
        s_20 = s_20;
        System.Console.WriteLine(vr0);
        System.Console.WriteLine(s_20[0, 0]);
    }
}
