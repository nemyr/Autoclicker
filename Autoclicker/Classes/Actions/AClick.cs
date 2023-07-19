
using Autoclicker.Classes.InputManaging;

namespace Autoclicker.Classes.Actions
{
    internal class AClick : MouseAction
    {
        public AClick(MouseActionSettings settings) : base(settings)
        {
        }

        protected override void Action()
        {
            while (IsRunning)
            {
                _inputManager.LMBDown();
                _inputManager.LMBUp();
                Thread.Sleep(Settings.Delay);
            }
        }
    }
}
