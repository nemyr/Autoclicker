using Autoclicker.Classes.InputManaging;

namespace Autoclicker.Classes.Actions
{
    internal abstract class MouseAction : IMouseAction
    {
        protected MouseActionSettings Settings { get;  set; }
        protected readonly InputManager _inputManager;

        public bool IsRunning { get => isRunning; }
        private bool isRunning = false;
        private Task task;

        protected MouseAction(MouseActionSettings settings) { 
            Settings = settings;
            _inputManager = new InputManager();
        }

        protected abstract void Action();

        public void TurnOff()
        {
            isRunning = false;
        }

        public void TurnOn()
        {
            isRunning = true;
            if (task == null || task.IsCompleted ) 
                task = new Task(Action);
            task.Start();
        }
    }
}
