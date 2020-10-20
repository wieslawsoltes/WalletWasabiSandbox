using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletPasswordViewModel : RoutableViewModel
	{
		private string _password;
		private string _confirmPassword;

		public GenerateWalletPasswordViewModel(NavigationState navigationState, IScreen wizardScreen, string title, WalletViewModel wallet, WalletManagerViewModel walletManager)
			: base(new NavigationState()
			{
				Screen = () => wizardScreen,
				HomeView = () => navigationState.HomeView(),
				CancelView = () => navigationState.CancelView(),
			}, "GenerateWalletPassword", title)
		{
			ShowCommand = ReactiveCommand.Create(() => wizardScreen.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(navigationState.CancelView()));
			NextCommand = ReactiveCommand.Create(() =>
			{
				wallet.Password = _password;
				wizardScreen.Router.Navigate.Execute(
					new GenerateWalletRecoveryViewModel(navigationState, wizardScreen, "Create Wallet", wallet, walletManager));
			});
		}

		public ICommand ShowCommand { get; }

		public ICommand CancelCommand { get; }

		public ICommand NextCommand { get; }

		public string Password
		{
			get => _password;
			set => this.RaiseAndSetIfChanged(ref _password, value);
		}

		public string ConfirmPassword
		{
			get => _confirmPassword;
			set => this.RaiseAndSetIfChanged(ref _confirmPassword, value);
		}
	}
}
