using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using WalletWasabi.Fluent.ViewModels;

namespace WalletWasabi.Fluent
{
	public class App : Application
	{
		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
			{
				desktop.MainWindow = new MainWindow()
				{
					DataContext = new MainViewModel()
				};
			}

			base.OnFrameworkInitializationCompleted();
		}
	}
}
