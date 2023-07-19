using Autoclicker.Classes.InputManaging.Flags;
using Autoclicker.Classes.InputManaging.Structs;
using System.Runtime.InteropServices;

namespace Autoclicker.Classes.InputManaging
{
    //details : https://www.codeproject.com/Articles/5264831/How-to-Send-Inputs-using-Csharp
    internal class InputManager
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        private static extern IntPtr GetMessageExtraInfo();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        public Point Position
        {
            get
            {
                return Cursor.Position;
            }
            set
            {
                Cursor.Position = value;
            }
        }

        private void SendMouseInput(uint eventFlags) {
            SendMouseInput(new MouseInput
            {
                dwFlags = eventFlags,
                dwExtraInfo = GetMessageExtraInfo()
            });
        }

        private void SendMouseInput(MouseInput mouseInput) {
            SendMouseInput(new MouseInput[] { mouseInput });
        }

        private void SendMouseInput(MouseInput[] mouseInputs)
        {
            SendInput(
                mouseInputs.Select(
                    mInp => new Input
                    {
                        type = (int)InputType.Mouse,
                        u = new InputUnion
                        {
                            mi = mInp
                        }
                    })
                .ToArray());
        }

        private void SendInput(Input input)
        {
            SendInput(new Input[] { input });
        }

        private void SendInput(Input[] inputs)
        {
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        public void LMBDown()
        {
            SendMouseInput((uint)MouseEventF.LeftDown);
        }

        public void LMBUp()
        {
            SendMouseInput((uint)MouseEventF.LeftUp);
        }

        public void MouseMove(int dx, int dy) {
            SendMouseInput(
                new MouseInput { 
                    dwFlags = (uint) MouseEventF.Move,
                    dx = dx,
                    dy = dy,
                    dwExtraInfo = GetMessageExtraInfo()
                }
            );
        }
    }
}
