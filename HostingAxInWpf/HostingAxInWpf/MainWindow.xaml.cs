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
using AxAXVLC;

namespace HostingAxInWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AxAXVLC.AxVLCPlugin2 vlcPlayer = new AxAXVLC.AxVLCPlugin2();
        AxAXVLC.AxVLCPlugin2 vlcPlayer2 = new AxAXVLC.AxVLCPlugin2();
        public MainWindow()
        {
            InitializeComponent();
            WFH1.Child = vlcPlayer;
            WFH2.Child = vlcPlayer2;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mrl = "file:///";
            string linkforward = @"rtsp://192.168.0.105/s1";
            string[] options = new string[1];

            options[0] = ":network-caching=200";
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                mrl += ofd.FileName;
                vlcPlayer.playlist.add(linkforward, "fc", options[0]);
                vlcPlayer2.playlist.add(mrl);
                vlcPlayer.playlist.play();
                vlcPlayer2.playlist.play();
            }
        }
    }
}
