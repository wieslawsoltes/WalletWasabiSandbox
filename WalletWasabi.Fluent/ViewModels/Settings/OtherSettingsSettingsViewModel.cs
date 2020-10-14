using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
    public class OtherSettingsSettingsViewModel : RoutableViewModel
	{
		public OtherSettingsSettingsViewModel(IScreen screen, string title) : base(screen, "OtherSettingsSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
