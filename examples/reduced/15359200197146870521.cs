// Generated by Fuzzlyn on 2018-06-25 13:39:42
// Seed: 15359200197146870521
// Reduced from 94.5 KiB to 0.3 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
struct S1
{
    public ulong F6;
}

public class Program
{
    static S1 s_4;
    static short[] s_14 = new short[]{-2};
    public static void Main()
    {
        s_4.F6 = (char)(0L ^ s_14[0]);
        System.Console.WriteLine(s_4.F6);
    }
}