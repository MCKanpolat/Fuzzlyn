// Generated by Fuzzlyn on 2018-06-25 14:25:26
// Seed: 4875637055389468069
// Reduced from 1.7 KiB to 0.2 KiB
// Debug: Outputs 49101
// Release: Outputs 4294950861
public class Program
{
    static short s_2 = -16436;
    public static void Main()
    {
        ulong vr0 = (char)(1U ^ s_2);
        System.Console.WriteLine(vr0);
    }
}
