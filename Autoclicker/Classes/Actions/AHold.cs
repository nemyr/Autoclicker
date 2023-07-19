namespace Autoclicker.Classes.Actions
{
    internal class AHold : MouseAction
    {
        public AHold(MouseActionSettings settings) : base(settings)
        {
        }

        protected override void Action()
        {
            _inputManager.LMBDown();
            while (IsRunning) { Thread.Sleep(Settings.Delay); }
            _inputManager.LMBUp();
        }
    }
}
