using Autoclicker.Classes.Actions;
namespace Autoclicker
{
    public partial class Form1 : Form
    {
        private MouseActionSettings MouseActionSettings { get; set; } = new MouseActionSettings();

        private IMouseAction? _mouseAction;

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += MouseWheelHandler;
            this.lbDelay.DataBindings.Add(new Binding("Text", MouseActionSettings, "Delay"));
            this.tbDx.DataBindings.Add(new Binding("Text", MouseActionSettings, "ShiftX"));
            this.tbDy.DataBindings.Add(new Binding("Text", MouseActionSettings, "ShiftY"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsKeyLocked(Keys.CapsLock))
            {
                _mouseAction ??= new AClick(MouseActionSettings);
                if (!_mouseAction.IsRunning)
                {
                    _mouseAction.TurnOn();
                    gbActionType.Enabled = false;
                }
            }
            else
            {
                _mouseAction?.TurnOff();
                gbActionType.Enabled = true;
            }
        }

        private void MouseWheelHandler(object? sender, MouseEventArgs e)
        {
            MouseActionSettings.Delay = Math.Max(10, MouseActionSettings.Delay + (e.Delta > 0 ? 10 : -10));
        }

        private void rbAct_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            switch (rb.Tag)
            {
                case "Click":
                    _mouseAction = new AClick(MouseActionSettings);
                    break;
                case "ClickHold":
                    _mouseAction = new AClickHold(MouseActionSettings);
                    break;
                case "Hold":
                case "Drag":
                case "Dragndrop":
                    break;
            }
        }
    }
}