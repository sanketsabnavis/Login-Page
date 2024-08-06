using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace Login
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // MainPage = new NavigationPage(new LoginPage());
        }
    }
}

