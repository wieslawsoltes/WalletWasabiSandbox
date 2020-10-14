using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager;

namespace WalletWasabi.Fluent.ViewModels.WalletExplorer
{
    public class AddWalletViewModel : RoutableViewModel
	{

		public AddWalletViewModel(IScreen screen, string title, RoutableViewModel home) : base(screen, "AddWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(new GenerateWalletViewModel(screen, "Create new Wallet", "", this, home)));
		}

		public ICommand ShowCommand { get; }
	}
}
