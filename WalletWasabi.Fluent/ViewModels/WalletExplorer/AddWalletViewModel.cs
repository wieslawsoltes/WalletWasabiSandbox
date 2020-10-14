using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels.WalletExplorer
{
    public class AddWalletViewModel : RoutableViewModel
	{
		public AddWalletViewModel(IScreen screen, string title, RoutableViewModel home) : base(screen, "AddWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(new WalletManagerViewModel(screen, "Create new Wallet", home)));
		}

		public ICommand ShowCommand { get; }
	}
}
