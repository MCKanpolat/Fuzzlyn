// Generated by Fuzzlyn on 2018-06-25 14:12:16
// Seed: 3103212072509109845
// Reduced from 43.3 KiB to 0.3 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        s_1 = -2;
        bool vr5 = (byte)(0L ^ s_1) < 0;
        if (vr5)
        {
            System.Console.WriteLine(true);
        }
        else
        {
        }
    }
}