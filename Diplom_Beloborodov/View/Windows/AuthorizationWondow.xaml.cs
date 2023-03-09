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
    /// Логика взаимодействия для AuthorizationWondow.xaml
    /// </summary>
    public partial class AuthorizationWondow : Window
    {
        public AuthorizationWondow()
        {
            InitializeComponent();
        }

        private void AutorizationApp_Click(object sender, RoutedEventArgs e)
        {
            var q = Helpers.BD.user24Entities.Authorizations.Where(i => i.Login == LoginTb.Text && i.Password == PassTb.Password).FirstOrDefault();
            if (q == null)
            {
                T1.Foreground = Brushes.Red;
                T2.Foreground = Brushes.Red;
            }
            else
            {
                StartWindow startWindow = new StartWindow();
                startWindow.Show();
                Close();
            }
        }

        private void Zabil_Click(object sender, RoutedEventArgs e)
        {
            SmenaPass smenaPass = new SmenaPass();
            smenaPass.Show();
            Close();
        }
    }
}
