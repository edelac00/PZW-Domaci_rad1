using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Domaci_rad1
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
            this.LeftButton.Click += new RoutedEventHandler(LB_Click);
            this.RightButton.Click += new RoutedEventHandler(RB_Click);
        }

        void RB_Click(object sender, RoutedEventArgs e)
        {
            this.LongRectangleContainer.Children.Add(new Rectangle()
            {
                Width = 300,
                Height = 30,
                Margin = new Thickness(0, 10, 0, 10),
                Fill = Brushes.Orchid
            });
        }

        void LB_Click(object sender, RoutedEventArgs e)
        {
            this.RectangleContainer.Children.Add(new Rectangle()
            {
                Width = 60,
                Height = 60,
                Margin = new Thickness(0, 10, 0, 10),
                Fill = Brushes.Blue
            });
        }







    }
}
