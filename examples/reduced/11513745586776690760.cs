// Generated by Fuzzlyn on 2018-06-25 13:10:25
// Seed: 11513745586776690760
// Reduced from 158.2 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
public class Program
{
    static short s_2;
    public static void Main()
    {
        var vr52 = s_2--;
        var vr53 = (ushort)(1U ^ s_2);
        ulong vr55 = vr53;
        System.Console.WriteLine(vr55);
    }
}
