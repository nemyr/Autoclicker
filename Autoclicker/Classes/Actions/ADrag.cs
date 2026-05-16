namespace Autoclicker.Classes.Actions
{
    internal class ADrag : MouseAction
    {
        private Random random = new Random();

        public ADrag(MouseActionSettings settings) : base(settings)
        {
        }

        protected override void Action()
        {
            var point = _inputManager.Position;
            try
            {
                _inputManager.LMBDown();
                var shiftX = Math.Abs(Settings.ShiftX);
                var shiftY = Math.Abs(Settings.ShiftY);
                while (IsRunning) { 
                    _inputManager.Position = new() { 
                        X = point.X + random.Next(-shiftX, shiftX), 
                        Y = point.Y + random.Next(-shiftY, shiftY)
                    };
                    Thread.Sleep(Settings.Delay);
                }
            } finally{ 
                _inputManager.LMBUp();
            }
        }
    }
}
