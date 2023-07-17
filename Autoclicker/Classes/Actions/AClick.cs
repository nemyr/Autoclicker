using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoclicker.Classes.Actions
{
    internal class AClick : MouseAction
    {
        private readonly InputManager _inputManager;
        public AClick(MouseActionSettings settings) : base(settings)
        {
            _inputManager = new InputManager();
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
