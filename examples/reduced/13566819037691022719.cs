// Generated by Fuzzlyn on 2018-06-03 22:39:59
// Seed: 13566819037691022719
// Reduced from 111.9 KB to 0.2 KB
// Debug: Outputs 18446744073709551551
// Release: Outputs 18446744073709551550
public class Program
{
    public static void Main()
    {
        byte[] vr150 = new byte[]{158};
        short vr151 = -30117;
        ulong vr152 = (ulong)((vr151 % (vr150[0] | 1)) | 1);
        System.Console.WriteLine(vr152);
    }
}