using MvmEshkere.Models;
using MvmEshkere.Views;

namespace MvmEshkere
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends_db";
        public static FriendRepository database;
        public static FriendRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new FriendRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
            }
        public App()
        {
            MainPage = new Shell { CurrentItem = new DbListPage() };
            //MainPage = new Shell { CurrentItem = new FriendsListPage() };
        }
    }
}