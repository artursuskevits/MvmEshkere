using System.Text;
using System.Threading.Tasks;
using MvmEshkere.Models;
using MvmEshkere.ViewModels;

namespace MvmEshkere.Views;


public partial class FriendPage : ContentPage
{
public FriendViewModel ViewModel { get; private set; }
public FriendPage(FriendViewModel vm)
{
    InitializeComponent();
    ViewModel = vm;
    this.BindingContext = ViewModel;
}
}