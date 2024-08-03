using DailyAccount.Pages;

namespace DailyAccount
{
    public partial class App : Application
    {

        public App()
        {

            MainPage = new AppShell(SingletonPage.CreatePage(Models.PageType.AddPage));

            //    InitializeComponent();

            //    var shell = new Shell();//

            //    var tabBar = new TabBar();//導航bar

            //    var tabs = new (string Title, string Icon, Type PageType)[] // 導航bar中的每個標籤，[]代表多個標籤組容器
            //    {
            //            ("Account", "account.png", typeof(AccountPage)),// 用typeof運算符獲取特定對象
            //            ("Add", "add.png", typeof(AddPage)),
            //            ("Note", "note.png", typeof(NotePage)),
            //            ("Analysis", "analysis.png", typeof(AnalysisPage)),
            //            ("Setting", "setting.png", typeof(SettingPage))
            //    };

            //    foreach (var (title, icon, pageType) in tabs)
            //    {
            //        var tab = new Tab
            //        {
            //            Title = title,
            //            Icon = icon
            //        };

            //        var shellContent = new ShellContent //Shell的子項，用來定義要顯示的內容
            //        {
            //            ContentTemplate = new DataTemplate(pageType) //ContentTemplate是ShellContent的屬性，指定用來創建內容的變數(pageType)，與相對應的頁面做切換
            //        };

            //        tab.Items.Add(shellContent);
            //        tabBar.Items.Add(tab);
            //    }

            //    shell.Items.Add(tabBar);

            //    MainPage = shell;
            //}
        }
    
    }
}
