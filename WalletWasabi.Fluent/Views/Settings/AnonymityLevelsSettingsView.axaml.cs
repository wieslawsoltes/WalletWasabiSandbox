using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Settings;

namespace WalletWasabi.Fluent.Views.Settings
{
	public class AnonymityLevelsSettingsView : ReactiveUserControl<AnonymityLevelsSettingsViewModel>
	{
		public AnonymityLevelsSettingsView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
