// Generated by Fuzzlyn on 2018-06-25 14:39:38
// Seed: 6831857306459586724
// Reduced from 107.0 KiB to 0.2 KiB
// Debug: Outputs -
// Release: Outputs ?
public class Program
{
    static char s_6;
    static sbyte s_11;
    public static void Main()
    {
        s_11 = -84;
        s_6 = (char)(byte)(1L | s_11);
        System.Console.WriteLine(s_6);
    }
}
