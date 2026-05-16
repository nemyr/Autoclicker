namespace Autoclicker.Classes.Actions
{
    internal class AHold : MouseAction
    {
        public AHold(MouseActionSettings settings) : base(settings)
        {
        }

        protected override void Action()
        {
            try
            {
                _inputManager.LMBDown();
                while (IsRunning) { Thread.Sleep(Settings.Delay); }
            }
            finally
            {
                _inputManager.LMBUp();
            }
        }
    }
}
