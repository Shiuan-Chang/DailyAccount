using System.ComponentModel;
using System.Reflection;

namespace DailyAccount.Views;

public partial class NaviBar : ContentView
{
    public NaviBar()
    {
        InitializeComponent();
        CreateNavigationButtons();

    }

    private void CreateNavigationButtons()
    {
        var pageTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(ContentPage))).ToList();
        int count = 0;
        foreach (var type in pageTypes)
        {
            if (type.Name == "MainPage")
                continue;
            count++;
            var titleAttribute = type.GetCustomAttribute<DisplayNameAttribute>();
            string pageTitle = titleAttribute?.DisplayName ?? "未命名";

            var navButton = new Button
            {
                Text = pageTitle,
                FontFamily = "Microsoft JhengHei",
                FontSize = 12,
                FontAttributes = FontAttributes.None
            };

            string imagePath = $"{pageTitle}.png";

            navButton.ImageSource = ImageSource.FromFile(imagePath);


            navButton.Clicked += (sender, e) => NavigateTo(type);
            ButtonContainer.Children.Add(navButton);
        }
    }

    private void NavigateTo(Type pageType)
    {
        var page = (ContentPage)Activator.CreateInstance(pageType);
        if (page != null)
        {
            // Assuming your main page has navigation implemented
            ((NavigationPage)Application.Current.MainPage).PushAsync(page);
        }
    }

}