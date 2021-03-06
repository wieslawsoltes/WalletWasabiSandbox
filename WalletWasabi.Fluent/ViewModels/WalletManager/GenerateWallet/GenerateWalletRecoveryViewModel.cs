using System;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletRecoveryViewModel : RoutableViewModel
	{
		private string[] _recoveryWords;

		public GenerateWalletRecoveryViewModel(NavigationStateViewModel navigationState, IScreen wizardScreen, string title, WalletViewModel wallet, WalletManagerViewModel walletManager)
			: base(new NavigationStateViewModel()
			{
				Screen = () => wizardScreen,
				Dialog = () => navigationState.Dialog(),
				NextView = () => navigationState.NextView(),
				CancelView = () => navigationState.CancelView(),
			}, "GenerateWalletRecovery", title)
		{
			ShowCommand = ReactiveCommand.Create(() => wizardScreen.Router.Navigate.Execute(this));
#if !USE_DIALOG
			CancelCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(navigationState.CancelView()));
#else
			CancelCommand = ReactiveCommand.Create(() =>
			{
				navigationState.Dialog().Router.NavigationStack.Clear();
				navigationState.Screen().Router.Navigate.Execute(navigationState.CancelView());
			});
#endif
			NextCommand = ReactiveCommand.Create(() =>
			{
				wallet.RecoveryWords = _recoveryWords;
				wizardScreen.Router.Navigate.Execute(
					new GenerateWalletConfirmViewModel(navigationState, wizardScreen, "Create Wallet", wallet, walletManager));
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
