// Generated by Fuzzlyn on 2018-06-25 13:10:14
// Seed: 11341599701680479828
// Reduced from 85.2 KiB to 0.2 KiB
// Debug: Outputs True
// Release: Outputs False
public class Program
{
    static ulong s_5 = 4264308512126998986UL;
    public static void Main()
    {
        var vr18 = 0 <= (char)(sbyte)(s_5 | '^');
        System.Console.WriteLine(vr18);
    }
}
