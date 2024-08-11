using DailyAccount.Pages;

namespace DailyAccount
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(SingletonPage.CreatePage(Models.PageType.AddPage));

        }
    }
}
