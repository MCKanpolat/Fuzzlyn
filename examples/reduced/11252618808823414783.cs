// Generated by Fuzzlyn on 2018-06-25 13:08:28
// Seed: 11252618808823414783
// Reduced from 84.2 KiB to 0.3 KiB
// Debug: Outputs 128
// Release: Outputs -128
public class Program
{
    static sbyte s_3;
    static sbyte s_9 = 127;
    public static void Main()
    {
        s_3 = s_9;
        char vr31 = (char)s_3++;
        uint vr33 = 0;
        int vr34 = (byte)(vr33 ^ s_3);
        System.Console.WriteLine(vr34);
    }
}