using Autoclicker.Classes.Actions;
using System.Windows.Input;
namespace Autoclicker
{
    public partial class Form1 : Form
    {
        private MouseActionSettings MouseActionSettings { get; set; } =
            new MouseActionSettings
            {
                Delay = 50,
                ShiftX = 0,
                ShiftY = 0
            };

        private IMouseAction _mouseAction;

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += MouseWheelHandler;
            this.lbDelay.Text = MouseActionSettings.Delay.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock) && !(_mouseAction?.IsRunning).GetValueOrDefault(false))
            {
                _mouseAction = new AClick(new MouseActionSettings() { Delay = MouseActionSettings.Delay });
                _mouseAction.TurnOn();
            }
            else
            {
                _mouseAction?.TurnOff();
            }
        }

        private void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            MouseActionSettings.Delay = Math.Max(10, MouseActionSettings.Delay + (e.Delta > 0 ? 10 : -10));
            lbDelay.Text = MouseActionSettings.Delay.ToString();
        }
    }
}