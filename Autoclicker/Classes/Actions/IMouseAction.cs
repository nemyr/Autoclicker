namespace Autoclicker.Classes.Actions
{
    internal interface IMouseAction
    {
        public bool IsRunning { get; }
        public void TurnOn();
        public void TurnOff();
    }
}
