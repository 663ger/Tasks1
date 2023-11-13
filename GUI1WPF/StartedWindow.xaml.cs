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
    /// Логика взаимодействия для StartedWindow.xaml
    /// </summary>
    public partial class StartedWindow : Page
    {
        public MainWindow mainWindows; // ссылка на родителя главной страницы
        public StartedWindow(MainWindow _mainWindows) // при открытии принимате родителя
        {
            InitializeComponent();
            mainWindows = _mainWindows; // сохраняет родителя
        }

        private void OpenPage(object sender, RoutedEventArgs e)
        {
            mainWindows.OpenPage(2); // открывает вторую страницу

        }

        private void OpenWindows(object sender, RoutedEventArgs e)
        {
            new Auth().ShowDialog(); // новое окно авторизации
        }
    }
}
