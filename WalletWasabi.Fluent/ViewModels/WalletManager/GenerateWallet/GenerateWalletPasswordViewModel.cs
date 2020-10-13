using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletPasswordViewModel : RoutableViewModel
	{
		private RoutableViewModel _cancel;
		private RoutableViewModel _next;
		private string _password;
		private string _confirmPassword;

		public GenerateWalletPasswordViewModel(IScreen wizard, string title, RoutableViewModel cancel) : base(wizard, "GenerateWalletPassword", title)
		{
			ShowCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(_cancel));
			NextCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(_next));
			_cancel = cancel;
			_next = new GenerateWalletRecoveryViewModel(wizard, "Create Wallet", cancel);
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
