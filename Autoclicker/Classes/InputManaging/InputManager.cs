using Autoclicker.Classes.InputManaging.Flags;
using Autoclicker.Classes.InputManaging.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Autoclicker.Classes.InputManaging
{
    internal class InputManager
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
        private static extern bool GetCursorPos();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        private static extern IntPtr GetMessageExtraInfo();

        public Point Position
        {
            get
            {
                return Position;
            }
            set
            {
                Cursor.Position = value;
            }
        }

        private void SendMouseLMBEvent(uint eventFlags) {
            Input[] input = new Input[] {
                new Input
                {
                    type = (int) InputType.Mouse,
                    u = new InputUnion
                    {
                        mi = new MouseInput
                        {
                            dwFlags = eventFlags,
                            dwExtraInfo = GetMessageExtraInfo()
                        }
                    }
                }
            };
            SendInput((uint)input.Length, input, Marshal.SizeOf(typeof(Input)));
        }

        public void LMBDown()
        {
            SendMouseLMBEvent((uint)MouseEventF.LeftDown);
        }

        public void LMBUp()
        {
            SendMouseLMBEvent((uint)MouseEventF.LeftUp);
        }

    }
}
