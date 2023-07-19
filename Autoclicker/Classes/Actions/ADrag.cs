namespace Autoclicker.Classes.Actions
{
    internal class ADrag : MouseAction
    {
        private Random random = new Random();
        private Point point;

        public ADrag(MouseActionSettings settings) : base(settings)
        {
            point = _inputManager.Position;
        }

        protected override void Action()
        {
            _inputManager.LMBDown();
            while (IsRunning) { 
                _inputManager.Position = new() { 
                    X = point.X + random.Next(-Settings.ShiftX, Settings.ShiftX), 
                    Y = point.Y + random.Next(-Settings.ShiftY, Settings.ShiftY)
                };
                Thread.Sleep(Settings.Delay);
            }
            _inputManager.LMBUp();
        }
    }
}
