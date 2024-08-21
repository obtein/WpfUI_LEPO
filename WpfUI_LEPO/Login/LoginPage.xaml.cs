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

namespace WpfUI_LEPO.Login
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        private static LoginPage page;
        public static LoginPage Instance
        {
            get
            {
                return page;
            }
            private set
            {
                page = value;
            }
        }
        public LoginPage()
        {
            InitializeComponent();
            Instance = this;
        }
    }
}
