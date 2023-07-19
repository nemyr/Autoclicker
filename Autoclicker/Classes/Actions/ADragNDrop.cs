using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoclicker.Classes.Actions
{
    internal class ADragNDrop : MouseAction
    {
        private readonly Random random = new Random();

        public ADragNDrop(MouseActionSettings settings) : base(settings)
        {
        }

        protected override void Action()
        {
            var point = _inputManager.Position;
            while (IsRunning)
            {
                _inputManager.LMBDown();
                _inputManager.Position = new Point( 
                    point.X + random.Next(-Settings.ShiftX, Settings.ShiftX), 
                    point.Y + random.Next(-Settings.ShiftY, Settings.ShiftY)
                    );
                _inputManager.LMBUp();
                Thread.Sleep(Settings.Delay);
            }
        }
    }
}
