using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ModelsClassLibrary
{
    public class MySampleViewModel : INotifyPropertyChanged
    {
        private string _text;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Text
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<string> MySampleList { get; } = new ObservableCollection<string>();

        public ICommand MyCommand { get; }

        public MySampleViewModel()
        {
            MyCommand = new RelayCommand(ExecuteMyCommand);
        }

        private void ExecuteMyCommand()
        {
            Text = "Button Clicked!";
        }
    }
}
