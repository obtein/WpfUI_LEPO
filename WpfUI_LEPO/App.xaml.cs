using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfUI_LEPO
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup ( StartupEventArgs e )
        {
            base.OnStartup( e );

            MainWindow app = new MainWindow();
            ApplicationViewModel context = new ApplicationViewModel();
            app.DataContext = context;
            app.Show();
        }

    }

}
