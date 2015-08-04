using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWolrdNameVMrMBP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int mycounter = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ClickMe_Click(object sender, RoutedEventArgs e)
        {
            mycounter++;
            this.HelloMessage.Text = "Hi, Button below has been pressed " + mycounter + " times now.";
        }

        private void myquit_Click(object sender, RoutedEventArgs e)
        {
            /// this.Application.Exit();
            //this.Close();
            //this.Exit();
            //App.Close();
            //System.Exit();
            //Environment.Close();
            //Window.Current.Close();   //produces ERROR
            //System.Windows.Exit();
            //Application.Exit();
            //this.Frame.sh
            //Environment.Exit(-1);
            //public void Exit();
            //Application.Current.Shutdown();
            //return;
            mycounter = 0;
            HelloMessage.Text = "CLick counter has been reset to " + mycounter + " now.";
        }
    }
}
