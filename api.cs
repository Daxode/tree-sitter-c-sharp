using System.Runtime.InteropServices;
using Unity.Burst;

[BurstCompile]
public class API
{
    [DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
    static extern System.IntPtr tree_sitter_c_sharp();
    
    // burst wrapper
    [BurstCompile]
    public static System.IntPtr TreeSitterCSharp() => tree_sitter_c_sharp();
}
