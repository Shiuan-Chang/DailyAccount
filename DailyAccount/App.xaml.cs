using DailyAccount.Pages;

namespace DailyAccount
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var shell = new Shell();//

            var tabBar = new TabBar();//導航bar

            var tabs = new (string Title, string Icon, Type PageType)[] // 導航bar中的每個標籤，[]代表多個標籤組容器
            {
                ("Account", "account.png", typeof(AccountPage)),// 用typeof運算符獲取特定對象
                ("Add", "add.png", typeof(AddPage)),
                ("Note", "note.png", typeof(NotePage)),
                ("Analysis", "analysis.png", typeof(AnalysisPage)),
                ("Setting", "setting.png", typeof(SettingPage))
            };

            foreach (var (title, icon, pageType) in tabs) 
            {
                var tab = new Tab
                {
                    Title = title,
                    Icon = icon
                };

                var shellContent = new ShellContent
                {
                    ContentTemplate = new DataTemplate(pageType)
                };

                tab.Items.Add(shellContent);
                tabBar.Items.Add(tab);
            }
         
            shell.Items.Add(tabBar);
           
            MainPage = shell;

        }
    }
}
