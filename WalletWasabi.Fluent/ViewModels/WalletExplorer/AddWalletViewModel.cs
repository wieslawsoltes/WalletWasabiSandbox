using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels.WalletExplorer
{
	public class AddWalletViewModel : RoutableViewModel
	{
		public AddWalletViewModel(NavigationState navigationState, string title, WalletManagerViewModel walletManager) : base(navigationState, "AddWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(walletManager));
		}

		public ICommand ShowCommand { get; }
	}
}
