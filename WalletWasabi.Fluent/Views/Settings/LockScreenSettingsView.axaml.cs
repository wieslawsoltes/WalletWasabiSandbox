using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Settings;

namespace WalletWasabi.Fluent.Views.Settings
{
	public class LockScreenSettingsView : ReactiveUserControl<LockScreenSettingsViewModel>
	{
		public LockScreenSettingsView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
