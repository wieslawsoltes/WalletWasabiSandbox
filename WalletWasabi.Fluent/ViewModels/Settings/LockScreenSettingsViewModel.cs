using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
    public class LockScreenSettingsViewModel : RoutableViewModel
	{
		public LockScreenSettingsViewModel(IScreen screen, string title) : base(screen, "LockScreenSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
