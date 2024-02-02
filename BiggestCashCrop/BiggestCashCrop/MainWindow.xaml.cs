using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BiggestCashCrop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.StateChanged += MainWindow_StateChanged;
        }

        private void MainWindow_StateChanged(object? sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                header.Margin = new Thickness(-300, 3, 0, 10);
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                header.Margin = new Thickness(-660, 3, 0, 10);
            }
            else if (this.WindowState == WindowState.Normal)
            {
                header.Margin = new Thickness(-300, 3, 0, 10);
            }
        }
    }
}