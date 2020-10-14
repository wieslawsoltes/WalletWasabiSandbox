using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
    public class BitcoinSettingsViewModel : RoutableViewModel
	{
		public BitcoinSettingsViewModel(IScreen screen, string title) : base(screen, "BitcoinSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
