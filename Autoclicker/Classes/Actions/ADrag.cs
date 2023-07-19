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
