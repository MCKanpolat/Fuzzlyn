// Generated by Fuzzlyn on 2018-06-25 14:41:40
// Seed: 6980586218547361932
// Reduced from 86.6 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort s_11;
    static uint[][, ] s_35 = new uint[][, ]{new uint[, ]{{0}}};
    public static void Main()
    {
        int vr0 = (0 % ((0 & (short)s_35[0][0, 0]) | 1)) & M30(s_35[0][0, 0]);
    }

    static ushort M30(uint arg0)
    {
        return s_11;
    }
}
