namespace Autoclicker.Classes.Actions
{
    internal class AClickHold : MouseAction
    {
        public AClickHold(MouseActionSettings settings) : base(settings)
        {
        }

        protected override void Action()
        {
            _inputManager.LMBDown();
            Thread.Sleep(Settings.Delay);
            _inputManager.LMBUp();
            Thread.Sleep(Settings.Delay);
        }
    }
}
