// Generated by Fuzzlyn on 2018-06-24 13:16:23
// Seed: 16232686675968383579
// Reduced from 12.8 KiB to 0.3 KiB
// Debug: Outputs 4798
// Release: Outputs -814214466
public class Program
{
    public static void Main()
    {
        ushort vr12 = default(ushort);
        byte[] vr13 = new byte[]{171};
        char vr14 = (char)(int)(11030537979359954312UL / (ulong)(vr12 | vr13[0]));
        System.Console.WriteLine((int)vr14);
    }
}
