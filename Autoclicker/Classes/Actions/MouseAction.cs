using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoclicker.Classes.Actions
{
    internal abstract class MouseAction : IMouseAction
    {
        protected MouseActionSettings Settings { get;  set; }
        public bool IsRunning { get => isRunning; }
        private bool isRunning = false;
        private readonly Task task;

        protected MouseAction(MouseActionSettings settings) { 
            Settings = settings;
            task = new Task(Run);
            task.Start();
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
        }
    }
}
