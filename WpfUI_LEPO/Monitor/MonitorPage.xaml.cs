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

namespace WpfUI_LEPO.Monitor
{
    /// <summary>
    /// Interaction logic for MonitorPage.xaml
    /// </summary>
    public partial class MonitorPage : UserControl
    {
        public static string outTest;
        private static int test = 100;

        private static MonitorPage page;
        public static MonitorPage Instance
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
        public MonitorPage(string input)
        {
            outTest = "***" + input + "***" + test;
            test += 100;
            InitializeComponent();
            Instance = this;
        }
        public MonitorPage (  )
        {
            outTest = "***" + test + "***";
            test += 100;
            InitializeComponent();
            Instance = this;
        }
    }
}
