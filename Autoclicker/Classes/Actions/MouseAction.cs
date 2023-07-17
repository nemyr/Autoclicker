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
        private bool IsRunnig { get; set; } = false;
        private readonly Task task;

        protected MouseAction(MouseActionSettings settings) { 
            Settings = settings;
            task = new Task(Run);
            task.Start();
        }

        protected abstract void Action();

        private void Run() { 
            while (IsRunnig)
            {
                Action();
            }
        }

        public void TurnOff()
        {
            IsRunnig = false;
        }

        public void TurnOn()
        {
            IsRunnig = true;
        }
    }
}
