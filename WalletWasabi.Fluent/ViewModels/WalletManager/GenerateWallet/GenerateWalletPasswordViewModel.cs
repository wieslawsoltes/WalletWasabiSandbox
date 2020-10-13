using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletPasswordViewModel : RoutableViewModel
	{
		private string _password;
		private string _confirmPassword;

		public GenerateWalletPasswordViewModel(IScreen homeScreen, IScreen wizardScreen, string title, RoutableViewModel cancel, RoutableViewModel home) : base(wizardScreen, "GenerateWalletPassword", title)
		{
			ShowCommand = ReactiveCommand.Create(() => wizardScreen.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => homeScreen.Router.Navigate.Execute(cancel));
			NextCommand = ReactiveCommand.Create(() => wizardScreen.Router.Navigate.Execute(
				new GenerateWalletRecoveryViewModel(homeScreen, wizardScreen, "Create Wallet", cancel, home)));
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
