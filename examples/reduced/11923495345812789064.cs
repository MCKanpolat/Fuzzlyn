// Generated by Fuzzlyn on 2018-06-18 16:08:29
// Seed: 11923495345812789064
// Reduced from 69.9 KiB to 0.3 KiB
// Debug: Outputs 0
// Release: Outputs 28
struct S0
{
    public byte F0;
}

struct S1
{
    public S0 F0;
    public S0 F1;
}

public class Program
{
    static S1 s_9;
    public static void Main()
    {
        s_9.F0 = M4();
        System.Console.WriteLine(s_9.F1.F0);
    }

    static S0 M4()
    {
        S0 vr33 = new S0();
        return vr33;
    }
}