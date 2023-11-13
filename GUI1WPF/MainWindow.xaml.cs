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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(0); // открывает стартовую страницу
        }
        public void OpenPage (int indexPage) // принимает номер страницы
        {
            if(indexPage ==0) // если номер страницы 0 то
                frame.Navigate(new StartedWindow(this)); // открывает стартовую страницу
            else if(indexPage ==2)
                frame.Navigate(new SecondWIndows(this)); // открывает вторую страницу
        }
    }
}
