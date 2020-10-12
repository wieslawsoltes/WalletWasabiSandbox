using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class SettingsViewModel : RoutableViewModel
	{
		public SettingsViewModel(IScreen screen) : base(screen, "Settings", "Settings")
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
