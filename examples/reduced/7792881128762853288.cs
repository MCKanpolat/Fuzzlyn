// Generated by Fuzzlyn on 2018-06-25 14:47:19
// Seed: 7792881128762853288
// Reduced from 47.9 KiB to 0.3 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static short s_3;
    public static void Main()
    {
        var vr44 = s_3--;
        sbyte vr45 = default(sbyte);
        bool vr46 = 't' >= (char)(2L | s_3);
        if (vr46)
        {
            System.Console.WriteLine(vr45);
        }
    }
}
