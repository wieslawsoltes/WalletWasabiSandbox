using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
	public class GenerateWalletViewModel : RoutableViewModel
	{
		private RoutableViewModel _cancel;
		private RoutableViewModel _next;
		private string _name;
		private string _password;
		private string _confirmPassword;
		private string[] _recoveryWords;

		public GenerateWalletViewModel(IScreen screen, string title, string name, RoutableViewModel cancel) : base(screen, "GenerateWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(_cancel));
			NextCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(_next));
			_cancel = cancel;
			_next = new GenerateWalletRecoveryViewModel(screen, "Create Wallet", cancel);
			_name = name;
		}

		public ICommand ShowCommand { get; }

		public ICommand CancelCommand { get; }

		public ICommand NextCommand { get; }

		public string Name
		{
			get => _name;
			set => this.RaiseAndSetIfChanged(ref _name, value);
		}

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

		public string[] RecoveryWords
		{
			get => _recoveryWords;
			set => this.RaiseAndSetIfChanged(ref _recoveryWords, value);
		}
	}
}
