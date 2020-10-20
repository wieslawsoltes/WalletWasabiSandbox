using System;
using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;
using WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
	public class GenerateWalletViewModel : RoutableViewModel, IScreen
	{
		public GenerateWalletViewModel(NavigationState navigationState, string title, WalletManagerViewModel walletManager) : base(navigationState, "GenerateWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() =>
			{
				navigationState.Screen().Router.Navigate.Execute(this);
				Router.NavigateAndReset.Execute(
					new GenerateWalletPasswordViewModel(
						navigationState,
						this,
						"Create Wallet",
						new WalletViewModel(navigationState, walletManager.Name) { Name = walletManager.Name },
						walletManager));
			});
		}

		public RoutingState Router { get; } = new RoutingState();

		public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

		public ICommand ShowCommand { get; }
	}
}
