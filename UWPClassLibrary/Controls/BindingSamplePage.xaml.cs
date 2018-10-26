using ModelsClassLibrary;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UWPClassLibrary.Controls
{
    public sealed partial class BindingSamplePage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private MySampleViewModel _viewModel;

        public MySampleViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    DataContext = _viewModel;
                    OnPropertyChanged();
                }
            }
        }

        public BindingSamplePage()
        {
            InitializeComponent();
        }
    }
}
