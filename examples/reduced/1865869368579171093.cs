// Generated by Fuzzlyn on 2018-06-25 14:03:13
// Seed: 1865869368579171093
// Reduced from 111.8 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public ushort F0;
    public uint F4;
}

public class Program
{
    static C0[, ] s_17 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        char vr0 = (char)((0 & s_17[0, 0].F0) % (s_17[0, 0].F4 | 1));
    }
}
