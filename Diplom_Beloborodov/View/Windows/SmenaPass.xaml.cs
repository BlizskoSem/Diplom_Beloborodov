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
    /// Логика взаимодействия для SmenaPass.xaml
    /// </summary>
    public partial class SmenaPass : Window
    {
        public SmenaPass()
        {
            InitializeComponent();
        }

        private void AutorizationApp_Click(object sender, RoutedEventArgs e)
        {
            var qwe = Helpers.BD.user24Entities.Authorizations.Where(i => i.Password == LoginTb.Text).FirstOrDefault();
            if (qwe != null)
            {
                Helpers.BD.user24Entities.Authorizations.Remove(qwe);
                Helpers.BD.user24Entities.SaveChanges();
                Models.Authorizations authorizations = new Models.Authorizations()
                {
                    Name = "Sem",
                    Login = "BlizskoSem",
                    Phone = 123456,
                    Password = PassTb.Password
                };
                Helpers.BD.user24Entities.Authorizations.Add(authorizations);
                Helpers.BD.user24Entities.SaveChanges();
                MessageBox.Show("Пароль изменён");
                AuthorizationWondow authorizationWondow = new AuthorizationWondow();
                authorizationWondow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
