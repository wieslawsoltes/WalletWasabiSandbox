using System;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletConfirmViewModel : RoutableViewModel
	{
		private string[] _recoveryWords;

		public GenerateWalletConfirmViewModel(NavigationState navigationState, IScreen wizardScreen, string title, WalletViewModel wallet, WalletManagerViewModel walletManager)
			: base(new NavigationState()
			{
				Screen = () => wizardScreen,
				Dialog = () => navigationState.Dialog(),
				HomeView = () => navigationState.HomeView(),
				CancelView = () => navigationState.CancelView(),
			}, "GenerateWalletConfirm", title)
		{
			_recoveryWords = wallet.RecoveryWords;

			ShowCommand = ReactiveCommand.Create(() => wizardScreen.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.NavigateAndReset.Execute(navigationState.CancelView()));
			NextCommand = ReactiveCommand.Create(() =>
			{
				walletManager.Wallets.Add(wallet);
#if USE_DIALOG
				navigationState.Dialog().Router.NavigationStack.Clear();
#endif
				navigationState.Screen().Router.NavigateAndReset.Execute(navigationState.HomeView());
			});
		}

		public ICommand ShowCommand { get; }

		public ICommand CancelCommand { get; }

		public ICommand NextCommand { get; }

		public string[] RecoveryWords
		{
			get => _recoveryWords;
			set => this.RaiseAndSetIfChanged(ref _recoveryWords, value);
		}
	}
}
