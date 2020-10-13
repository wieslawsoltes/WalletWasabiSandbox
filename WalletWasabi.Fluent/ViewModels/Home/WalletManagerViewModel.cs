using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class WalletManagerViewModel : RoutableViewModel
	{
		public WalletManagerViewModel(IScreen screen, string title = "Wallet Manager") : base(screen, "WalletManager", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
