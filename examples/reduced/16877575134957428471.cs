// Generated by Fuzzlyn on 2018-06-25 13:49:32
// Seed: 16877575134957428471
// Reduced from 12.8 KiB to 0.3 KiB
// Debug: Outputs 65534
// Release: Outputs -2
public class Program
{
    static byte s_1 = 254;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        var vr12 = (char)(254 | (sbyte)M8());
        int vr14 = vr12;
        System.Console.WriteLine(vr14);
    }

    static byte M8()
    {
        return s_1;
    }
}
