using Microsoft.Toolkit.Wpf.UI.XamlHost;
using ModelsClassLibrary;

namespace WpfApp1
{
    public partial class BindingPage
    {
        public MySampleViewModel ViewModel { get; }

        public BindingPage()
        {
            InitializeComponent();
            ViewModel = new MySampleViewModel();
            DataContext = ViewModel;
        }

        private void MyUwpTextBox_ChildChanged(object sender, System.EventArgs e)
        {
            if (myUwpTextBox.Child is Windows.UI.Xaml.Controls.TextBox textBox)
            {
                textBox.SetBinding(Windows.UI.Xaml.Controls.TextBox.TextProperty, new Windows.UI.Xaml.Data.Binding
                {
                    Source = ViewModel,
                    Path = new Windows.UI.Xaml.PropertyPath("Text"),
                    Mode = Windows.UI.Xaml.Data.BindingMode.TwoWay,
                    UpdateSourceTrigger = Windows.UI.Xaml.Data.UpdateSourceTrigger.PropertyChanged
                });
            }
        }

        private void WindowsXamlHost_ChildChanged(object sender, System.EventArgs e)
        {
            if ((sender as WindowsXamlHost).Child is UWPClassLibrary.Controls.BindingSamplePage bindingSamplePage)
            {
                bindingSamplePage.ViewModel = ViewModel;
            }
        }
    }
}
