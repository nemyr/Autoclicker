namespace Autoclicker.Classes.Actions
{
    internal abstract class MouseAction : IMouseAction
    {
        protected MouseActionSettings Settings { get;  set; }
        public bool IsRunning { get => isRunning; }
        private bool isRunning = false;
        private Task task;

        protected MouseAction(MouseActionSettings settings) { 
            Settings = settings;
        }

        protected abstract void Action();

        private void Run() { 
            while (IsRunning)
            {
                Action();
            }
        }

        public void TurnOff()
        {
            isRunning = false;
        }

        public void TurnOn()
        {
            isRunning = true;
            if (task == null || task.IsCompleted ) 
                task = new Task(Run);
            task.Start();
        }
    }
}
