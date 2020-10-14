using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
    public class TorSettingsViewModel : RoutableViewModel
	{
		public TorSettingsViewModel(IScreen screen, string title) : base(screen, "TorSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
