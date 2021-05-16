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
            MainFrame.Content = new AudiomaterialsIELS();

        }

        public void ClickExit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);

        }

        

        public void ButHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Home());
            PageTitle.Content = "Home";
        }

        public void ButTOEFL_Click(object sender, RoutedEventArgs e)
        {
           MainFrame.Navigate(new TOEFL());
            PageTitle.Content = "TOEFL";
        }


        public void ButIELTS_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new IELTS());
            PageTitle.Content = "IELTS";

        }

        public void ButBooks_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Books());
            PageTitle.Content = "Books";
        }

        public void ButAudiobooks_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Audiobooks());
            PageTitle.Content = "Audiobooks";
        }

        public void ButVocabulary_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Vocabulary());
            PageTitle.Content = "Vocabulary";
        }


        public void ClickAudioMaterialsIELTS(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AudiomaterialsIELS());
            PageTitle.Content = "AudiomaterialsIELS";
        }

        public void ClickTextMaterialsIELTS(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TextmaterialsIELTS());
            PageTitle.Content = "TextmaterialsIELTS";
        }

        public void ClickTextMaterialsTOELF(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TextmaterialsTOELF());
            PageTitle.Content = "TextmaterialsTOELF";
        }

        public void ClickAudioMaterialsTOELF(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AudiomaterialsTOELF());
            PageTitle.Content = "AudiomaterialsTOELF";
        }

    }
}
