using System.Diagnostics;
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
using CommunityToolkit.Mvvm.Input;
using Wpf.Ui.Controls;
using WpfUI_LEPO.Login;
using WpfUI_LEPO.Monitor;

namespace WpfUI_LEPO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string [] test = { "leley", "loloy"};
        UserControl current;
        UserControl previous;
        MonitorPage m00, m01;
        public MainWindow ()
        {
            InitializeComponent();
            passBox.PasswordChanged += PassBox_PasswordChanged;
            m00 = new MonitorPage( "Test2" );
            m00.Tag = "lolo2";
            m01 = new MonitorPage( "Test1" );
            m01.Tag = "lolo1";
        }
        /// <summary>
        /// TODO: Implement a system where users can add and remove new users with passwords
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PassBox_PasswordChanged ( object sender, RoutedEventArgs e )
        {
            if ( userNameBox.Text == "admin" && passBox.Password == "admin" )
            {
                Trace.WriteLine( "welcome" );
                passBox.Visibility = Visibility.Collapsed;
                userNameBox.Visibility = Visibility.Collapsed;
                RootNavigation.Visibility = Visibility.Visible;
            }
            Trace.WriteLine( passBox.Password );
        }


        //Work on progress
        /// <summary>
        /// To add new elements to the navigationview
        /// </summary>
        private void DummyAdder ()
        {
            //RootNavigation.MenuItems.Clear();
            var mn = new NavigationViewItem()
            {
                Content = "WOALA",
                Icon = new SymbolIcon { Symbol = SymbolRegular.TableLightning24 },
                TargetPageType = typeof( LoginPage ),
                //TargetPageTag = "ProjectPage"
            };
            RootNavigation.MenuItems.Add( mn );

            //RootNavigation.Navigate( "LoginPage" );
        }

        private void RootNavigation_BackRequested ( NavigationView sender, RoutedEventArgs args )
        {
            App.Current.Dispatcher.BeginInvoke( () => { sender.GoBack(); } );
        }

        private void RootNavigation_Navigated ( NavigationView sender, NavigatedEventArgs args )
        {
            // sender.SelectedItem o an seçili şeyi döndürüyor, args.Page. de tıklanan şeyi
            Trace.WriteLine($"Navigated   from {sender.SelectedItem} to {args.Page.ToString()}" );
        }
        /// <summary>
        /// TODO : Navigating ve navigated farkı sadece canceleventargs mı ??? araştır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RootNavigation_Navigating ( NavigationView sender, Wpf.Ui.Controls.NavigatingCancelEventArgs args )
        {
            Trace.WriteLine( $"Navigating  from {sender.SelectedItem} to {args.Page.ToString()}");
        }
    }
}