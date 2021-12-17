using System;
using System.Windows;
using System.Windows.Media;

namespace MVVM_Dont_Starve_Quiz
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

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModels.ApplicationViewModel();
            player.Stop();
        }

        private static MediaPlayer player = new MediaPlayer();
        private static readonly Uri[] uris = new Uri[3];

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            InitQueue();
            PlayQueue();
        }

        private static void InitQueue()
        {
            uris[0] = new Uri(@"D:\\Study\\3 курс\\1 полугодие\\Инженерия Знаний\\ЛР\\ЛР3\\MVVM Dont'Starve Quiz\\MVVM Dont Starve Quiz\\Music\\1.mp3");
            uris[1] = new Uri(@"D:\\Study\\3 курс\\1 полугодие\\Инженерия Знаний\\ЛР\\ЛР3\\MVVM Dont'Starve Quiz\\MVVM Dont Starve Quiz\\Music\\2.mp3");
            uris[2] = new Uri(@"D:\\Study\\3 курс\\1 полугодие\\Инженерия Знаний\\ЛР\\ЛР3\\MVVM Dont'Starve Quiz\\MVVM Dont Starve Quiz\\Music\\3.mp3");
        }

        private static void PlayQueue()
        {      
            player.Open(uris[new Random().Next(0, 3)]);
            player.Play();
            player.Volume = 0.01;
        }
    }
}
