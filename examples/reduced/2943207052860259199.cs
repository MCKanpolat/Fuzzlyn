// Generated by Fuzzlyn on 2018-06-22 05:07:08
// Seed: 2943207052860259199
// Reduced from 54.3 KiB to 0.4 KiB
// Debug: Outputs 1864761314
// Release: Outputs 226
public class Program
{
    public static void Main()
    {
        var vr30 = new int[]{0};
        vr30[0] = 1864761314;
        int vr32 = vr30[0];
        var vr33 = (byte)vr32;
        M10(vr33);
        var vr34 = new int[]{0};
        vr34[0] = 1864761314;
        int vr36 = vr34[0];
        ulong vr37 = (ulong)vr36;
        System.Console.WriteLine(vr37);
    }

    static bool M10(byte arg1)
    {
        return true;
    }
}