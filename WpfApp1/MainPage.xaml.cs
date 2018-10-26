using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CustomControlsButton_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow.Content as Frame).Navigate(new CustomControlPage());
        }

        private void MyUwpButton_ChildChanged(object sender, EventArgs e)
        {
            if (myUwpButton.Child is Windows.UI.Xaml.Controls.Button button)
            {
                button.Content = "Wrapped Controls";
                button.Click += (s, args) =>
                {
                    (Application.Current.MainWindow.Content as Frame).Navigate(new WrappedControlsPage());
                };
            }
        }

        private void BindingButton_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow.Content as Frame).Navigate(new BindingPage());
        }
    }
}
