// Generated by Fuzzlyn on 2018-06-25 14:22:59
// Seed: 4567270456721659322
// Reduced from 139.5 KiB to 0.3 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
public class Program
{
    static uint s_13;
    public static void Main()
    {
        var vr14 = new sbyte[, ][]{{new sbyte[]{-2}}};
        char vr16 = (char)(0 ^ vr14[0, 0][0]);
        s_13 = vr16;
        System.Console.WriteLine(s_13);
    }
}