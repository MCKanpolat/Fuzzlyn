// Generated by Fuzzlyn on 2018-06-18 21:42:14
// Seed: 14680129741462978027
// Reduced from 3.7 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public uint F0;
    public sbyte F2;
    public ushort F3;
    public sbyte F5;
    public uint F6;
    public S0(sbyte f2, sbyte f4): this()
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        var vr1 = new long[][, ]{new long[, ]{{0}}};
        M1(vr1);
    }

    static ushort M1(long[][, ] arg0)
    {
        S0 var0 = new S0((sbyte)(0 & arg0[0][0, 0]), (sbyte)arg0[0][0, 0]);
        return var0.F3;
    }
}