using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels.WalletExplorer
{
	public class AddWalletViewModel : RoutableViewModel
	{
		public AddWalletViewModel(NavigationStateViewModel navigationState, string title, WalletManagerViewModel walletManager) : base(navigationState, "AddWallet", title)
		{
#if !USE_DIALOG
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(walletManager));
#else
			ShowCommand = ReactiveCommand.Create(() => navigationState.Dialog().Router.Navigate.Execute(walletManager));
#endif
		}

		public ICommand ShowCommand { get; }
	}
}
