using System;
using System.Windows;
using Windows.UI.Popups;

namespace WpfApp1
{
    public partial class CustomControlPage
    {
        public CustomControlPage()
        {
            InitializeComponent();
        }

        private void myUwpButton_ChildChanged(object sender, EventArgs e)
        {
            if (myUwpButton.Child is Windows.UI.Xaml.Controls.Button button)
            {
                button.Content = "UWP Button";
                button.Click += (s, args) =>
                {
                    MessageBox.Show("UWP Button, WPF MessageBox!");
                };
            }
        }

        private async void WPFButton_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("WPF Button, UWP Message Dialog!");
            await messageDialog.ShowAsync();
        }
    }
}
