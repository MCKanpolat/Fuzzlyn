// Generated by Fuzzlyn on 2018-06-18 14:21:38
// Seed: 15693495548410845043
// Reduced from 16.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public ulong F1;
    public sbyte F5;
}

public class Program
{
    static S0 s_9;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        int var0 = ((short)s_9.F1 | 1) | (s_9.F5 - s_9.F5);
        System.Console.WriteLine(var0);
    }
}