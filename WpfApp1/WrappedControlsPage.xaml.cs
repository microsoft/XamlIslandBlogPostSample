using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;

namespace WpfApp1
{
    public partial class WrappedControlsPage
    {
        public WrappedControlsPage()
        {
            InitializeComponent();
            inkCanvas.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Pen | CoreInputDeviceTypes.Touch;
        }
    }
}
