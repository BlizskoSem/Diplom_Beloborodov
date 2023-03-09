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
using System.Windows.Shapes;

namespace Diplom_Beloborodov.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Oznakomlenie_Copy_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.FactsPages());
        }

        private void Oznakomlenie_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.OznokPage());
        }

        private void Oznakomlenie_Copy6_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWondow authorizationWondow = new AuthorizationWondow();
            authorizationWondow.Show();
            Close();
        }

        private void Oznakomlenie_Copy1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Oznakomlenie_Copy2_Click(object sender, RoutedEventArgs e)
        {
            GamePages.TestWindow testWindow = new GamePages.TestWindow();
            testWindow.Show();
            Close();
        }
    }
}
