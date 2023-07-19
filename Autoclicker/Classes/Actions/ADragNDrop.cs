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
        private Point point;

        public ADragNDrop(MouseActionSettings settings) : base(settings)
        {
            point = _inputManager.Position;
        }

        protected override void Action()
        {
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
