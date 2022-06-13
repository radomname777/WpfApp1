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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringBuilder StrB { get; set; } = new StringBuilder();
        public MainWindow(){InitializeComponent();}
        private byte RandomReturn(){ return Convert.ToByte(Random.Shared.Next(0,255)); }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Random.Shared.Next(0, 255);
            if (sender is Button btn)
            {
                btn.Background = new SolidColorBrush(Color.FromRgb(RandomReturn(),RandomReturn(),RandomReturn()));
                MessageBox.Show(btn.Content.ToString(),$"My Color:{btn.Background}");
            }
        }

        private void Mouse_Right(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                if (StrB.Length != 0) btn.Content = ", "+btn.Content;
                StrB.Append(btn.Content);
                Title =  StrB.ToString();
                grid.Children.Remove(btn);
            }
        }
    }
}
