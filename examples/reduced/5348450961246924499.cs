// Generated by Fuzzlyn on 2018-06-24 13:07:08
// Seed: 5348450961246924499
// Reduced from 17.6 KiB to 0.3 KiB
// Debug: Outputs 182
// Release: Outputs 5302
class C0
{
    public ushort F0;
    public C0(ushort f0)
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        C0 vr17 = new C0(5302);
        vr17.F0 = vr17.F0;
        vr17.F0 = (byte)vr17.F0;
        System.Console.WriteLine(vr17.F0);
    }
}