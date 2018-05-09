using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyTonKho.UserControlLayout
{
    /// <summary>
    /// Interaction logic for ControlBarWindow.xaml
    /// </summary>
    public partial class ControlBarWindow : UserControl
    {
        public ControlBarWindow()
        {
            InitializeComponent();
        }

        private void Button_CloseWindow(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            parentWindow.Close();
        }

        private void Button_MaxWindow(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow.WindowState != WindowState.Maximized)
                parentWindow.WindowState = WindowState.Maximized;
            else
                parentWindow.WindowState = WindowState.Normal;
        }

        private void Button_MinWindow(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow.WindowState != WindowState.Minimized)
                parentWindow.WindowState = WindowState.Minimized;
            else
                parentWindow.WindowState = WindowState.Normal;
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            parentWindow.DragMove();
        }
    }
}
