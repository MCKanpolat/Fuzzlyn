// Generated by Fuzzlyn on 2018-06-25 14:06:21
// Seed: 2326333203629612395
// Reduced from 32.4 KiB to 0.5 KiB
// Debug: Outputs -421268402
// Release: Outputs 0
struct S0
{
    public long F7;
}

public class Program
{
    static int[] s_4 = new int[]{0};
    static ulong s_5 = 4726661832958538830UL;
    public static void Main()
    {
        S0 vr12 = new S0();
        short[][, ] vr15 = new short[][, ]{new short[, ]{{-6806}}};
        var vr16 = 0 >= (char)(vr12.F7 ^ vr15[0][0, 0]);
        if (vr16)
        {
        }
        else
        {
            s_4[0] = (int)s_5;
        }

        System.Console.WriteLine(s_4[0]);
    }
}
