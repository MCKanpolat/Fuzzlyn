// Generated by Fuzzlyn on 2018-06-19 05:05:34
// Seed: 3951804916489983786
// Reduced from 315.6 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs -2
public class Program
{
    static short s_8;
    public static void Main()
    {
        var vr17 = new sbyte[,, ]{{{-2}}};
        char vr24 = (char)(s_8 | vr17[0, 0, 0]);
        System.Console.WriteLine((int)vr24);
    }
}
