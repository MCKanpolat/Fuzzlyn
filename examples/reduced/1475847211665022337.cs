// Generated by Fuzzlyn on 2018-06-25 13:35:52
// Seed: 1475847211665022337
// Reduced from 41.7 KiB to 0.2 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static char s_4;
    public static void Main()
    {
        long vr0 = 0 % ((0 & (-2147483648 % (int)(18446744073709551615UL | s_4))) | 1);
    }
}
