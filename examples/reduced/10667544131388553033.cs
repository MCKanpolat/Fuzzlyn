// Generated by Fuzzlyn on 2018-06-18 17:31:54
// Seed: 10667544131388553033
// Reduced from 193.6 KiB to 0.4 KiB
// Debug: Outputs 65
// Release: Outputs 0
struct S0
{
    public char F0;
}

struct S1
{
    public S0 F2;
    public char F3;
    public S0 F7;
    public S1(char f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    static S1 s_42 = new S1('A');
    public static void Main()
    {
        s_42.F2 = M78();
        System.Console.WriteLine((int)s_42.F3);
    }

    static S0 M78()
    {
        return s_42.F7;
    }
}