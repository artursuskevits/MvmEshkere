using Microsoft.Maui.Controls;
using MvmEshkere;
using MvmEshkere.Views;

namespace MvmEshkere
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Shell.SetFlyoutBehavior(this, FlyoutBehavior.Disabled);

            Routing.RegisterRoute("MainPage", typeof(FriendsListPage));
        }
    }
}
