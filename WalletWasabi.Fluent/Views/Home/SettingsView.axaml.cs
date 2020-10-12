using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.Views.Home
{
	public class SettingsView : ReactiveUserControl<SettingsViewModel>
	{
		public SettingsView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
