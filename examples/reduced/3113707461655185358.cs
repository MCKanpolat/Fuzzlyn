// Generated by Fuzzlyn on 2018-06-25 14:13:19
// Seed: 3113707461655185358
// Reduced from 86.1 KiB to 0.3 KiB
// Debug: Outputs False
// Release: Outputs True
public class Program
{
    static sbyte[,, ] s_2 = new sbyte[,, ]{{{-10}}};
    public static void Main()
    {
        bool[] vr16 = new bool[]{false};
        vr16[0] = ':' > (ushort)(0 ^ s_2[0, 0, 0]);
        System.Console.WriteLine(vr16[0]);
    }
}