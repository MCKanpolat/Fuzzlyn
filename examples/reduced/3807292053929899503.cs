// Generated by Fuzzlyn on 2018-06-03 23:47:59
// Seed: 3807292053929899503
// Reduced from 119.1 KB to 0.3 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[, ] s_1 = new ushort[, ]{{13234}};
    static int[, ] s_5 = new int[, ]{{10}};
    public static void Main()
    {
        bool vr83 = (-735854079 == (0 & s_1[0, 0])) && (-1602131502 == -32768);
        ushort vr84 = (ushort)s_5[0, 0];
    }
}