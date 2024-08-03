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
        var pageTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(ContentPage)));
        int count = 0;
        foreach (var type in pageTypes)
        {
            count++;
            var titleAttribute = type.GetCustomAttribute<DisplayNameAttribute>();
            string formTitle = titleAttribute?.DisplayName ?? "未命名";

            var navButton = new Button
            {
                Text = formTitle,
                FontFamily = "Microsoft JhengHei",
                FontSize = 12,
                FontAttributes = FontAttributes.None
            };

            string imagePath = $"Resources/Images/{type.Name}.png";
            if (File.Exists(imagePath))
            {
                navButton.ImageSource = ImageSource.FromFile(imagePath);
            }

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