// Generated by Fuzzlyn on 2018-06-25 13:35:52
// Seed: 14709057395069829045
// Reduced from 36.8 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        var vr1 = new short[][, ]{new short[, ]{{0}}};
        bool vr3 = ((0 & vr1[0][0, 0]) != 0) && false;
        vr1[0][0, 0] = vr1[0][0, 0];
    }
}
