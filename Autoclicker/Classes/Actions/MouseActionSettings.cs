using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Autoclicker.Classes.Actions
{
    internal class MouseActionSettings: INotifyPropertyChanged
    {
        private int delay = 50;
        private int shiftX = 0;
        private int shiftY = 0;

        public int Delay {
            get => delay;
            set {
                delay = value;
                OnPropertyChanged();
            }
        }

        public int ShiftX { 
            get => shiftX;
            set
            {
                shiftX = value;
                OnPropertyChanged();
            }
        }

        public int ShiftY { 
            get => shiftY;
            set
            {
                shiftY = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
