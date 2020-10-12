using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class WalletManagerViewModel : RoutableViewModel
	{
		public WalletManagerViewModel(IScreen screen) : base(screen, "WalletManager", "Wallet Manager")
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
