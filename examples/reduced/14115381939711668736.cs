// Generated by Fuzzlyn on 2018-06-19 15:35:48
// Seed: 14115381939711668736
// Reduced from 7.7 KiB to 0.4 KiB
// Debug: Outputs 0
// Release: Outputs 17528
struct S0
{
    public bool F0;
}

struct S1
{
    public S0 F6;
    public ushort F7;
}

class C0
{
    public S1 F6;
}

public class Program
{
    public static void Main()
    {
        C0 vr7 = new C0();
        M1(vr7);
    }

    static char M1(C0 arg0)
    {
        arg0.F6.F6 = M3();
        System.Console.WriteLine(arg0.F6.F7);
        return '~';
    }

    static S0 M3()
    {
        return new S0();
    }
}