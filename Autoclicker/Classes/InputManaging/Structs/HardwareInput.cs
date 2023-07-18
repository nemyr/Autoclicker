using System.Runtime.InteropServices;

namespace Autoclicker.Classes.InputManaging.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HardwareInput
    {
        public uint uMsg;
        public ushort wParamL;
        public ushort wParamH;
    }
}
