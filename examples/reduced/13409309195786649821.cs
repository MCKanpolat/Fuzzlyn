// Generated by Fuzzlyn on 2018-06-25 13:25:41
// Seed: 13409309195786649821
// Reduced from 187.8 KiB to 0.2 KiB
// Debug: Outputs 55285
// Release: Outputs 4294957045
public class Program
{
    static short s_2;
    public static void Main()
    {
        s_2 = -10252;
        char vr63 = (char)(1U ^ s_2);
        uint vr65 = vr63;
        System.Console.WriteLine(vr65);
    }
}
