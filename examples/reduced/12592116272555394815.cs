// Generated by Fuzzlyn on 2018-06-26 04:35:25
// Seed: 12592116272555394815
// Reduced from 3.5 KiB to 0.2 KiB
// Debug: Outputs -52224
// Release: Outputs 0
public class Program
{
    public static void Main()
    {
        var vr14 = new ushort[]{0};
        vr14 = new ushort[]{52280};
        var vr16 = (sbyte)vr14[0] - vr14[0];
        System.Console.WriteLine(vr16);
    }
}