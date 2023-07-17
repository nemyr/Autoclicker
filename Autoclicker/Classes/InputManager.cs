using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Autoclicker.Classes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardInput
    {
        public ushort wVk;
        public ushort wScan;
        public uint dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MouseInput
    {
        public int dx;
        public int dy;
        public uint mouseData;
        public uint dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HardwareInput
    {
        public uint uMsg;
        public ushort wParamL;
        public ushort wParamH;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InputUnion
    {
        [FieldOffset(0)] public MouseInput mi;
        [FieldOffset(0)] public KeyboardInput ki;
        [FieldOffset(0)] public HardwareInput hi;
    }

    public struct Input
    {
        public int type;
        public InputUnion u;
    }

    internal class InputManager
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);
        
        [DllImport("user32.dll", EntryPoint ="GetCursorPos")]
        private static extern bool GetCursorPos();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        public Point Position { 
            get { 
                return Position; 
            }
            set { 
                Cursor.Position = value; }
            }

        public void LMBDown() 
        {
        
        }

        public void LMBUp()
        {

        }

    }
}
