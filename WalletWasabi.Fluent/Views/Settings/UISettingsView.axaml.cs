using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Settings;

namespace WalletWasabi.Fluent.Views.Settings
{
	public class UISettingsView : ReactiveUserControl<UISettingsViewModel>
	{
		public UISettingsView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
