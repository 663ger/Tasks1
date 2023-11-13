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

namespace GUI1WPF
{
    /// <summary>
    /// Логика взаимодействия для SecondWIndows.xaml
    /// </summary>
    public partial class SecondWIndows : Page
    {
        public MainWindow mainWindow;
        public SecondWIndows(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void OpenSecondWindows(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(0);
        }
    }
}
