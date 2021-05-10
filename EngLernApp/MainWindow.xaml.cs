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

namespace WpfAppChapter2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Home();

        }

        public void ButHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Home());
        }

        public void ButTOEFL_Click(object sender, RoutedEventArgs e)
        {
           MainFrame.Navigate(new TOEFL());
        }


        public void ButIELTS_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new IELTS());
        }

        public void ButBooks_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Books());
        }

        public void ButAudiobooks_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Audiobooks());
        }

        public void ButVocabulary_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Vocabulary());
        }



    }
}
