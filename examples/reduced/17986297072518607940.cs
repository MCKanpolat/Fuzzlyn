// Generated by Fuzzlyn on 2018-06-03 23:25:44
// Seed: 17986297072518607940
// Reduced from 28.7 KB to 0.2 KB
// Debug: Outputs 53761
// Release: Outputs 4294955521
public class Program
{
    static short s_2 = -11776;
    public static void Main()
    {
        ushort vr110 = (ushort)(s_2 ^ 1L);
        long vr112 = vr110;
        System.Console.WriteLine(vr112);
    }
}