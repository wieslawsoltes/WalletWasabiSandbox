using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Settings;

namespace WalletWasabi.Fluent.Views.Settings
{
	public class TorSettingsView : ReactiveUserControl<TorSettingsViewModel>
	{
		public TorSettingsView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
