using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using HotAvalonia;

namespace Example;

public partial class App : Application
{
    public override void Initialize()
    {
        this.EnableHotReload(); // Ensure this line **precedes** `AvaloniaXamlLoader.Load(this);`
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow(){DataContext = new ViewModel()};
        }

        base.OnFrameworkInitializationCompleted();
    }
}
