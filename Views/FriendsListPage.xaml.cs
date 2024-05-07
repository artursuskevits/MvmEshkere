using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvmEshkere.Models;
using MvmEshkere.ViewModels;

namespace MvmEshkere.Views;

public partial class FriendsListPage : ContentPage
{
    public FriendsListPage()
    {
        InitializeComponent();
        BindingContext = new FriendListViewModel() { Navigation = this.Navigation };
    }
}