// Generated by Fuzzlyn on 2018-06-22 02:31:22
// Seed: 15015139301391061850
// Reduced from 16.0 KiB to 0.2 KiB
// Debug: Outputs True
// Release: Outputs False
public class Program
{
    public static void Main()
    {
        var vr5 = new ushort[]{0};
        vr5[0] = 65535;
        ushort vr10 = vr5[0]++;
        bool vr12 = vr10 > 0;
        System.Console.WriteLine(vr12);
    }
}