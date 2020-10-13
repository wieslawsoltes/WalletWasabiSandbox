using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
	public class GenerateWalletViewModel : RoutableViewModel, IScreen
	{
		private string _name;
		private string _password;
		private string _confirmPassword;
		private string[] _recoveryWords;

		public GenerateWalletViewModel(IScreen screen, string title, string name, RoutableViewModel cancel, RoutableViewModel home) : base(screen, "GenerateWallet", title)
		{
			_name = name;
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
			Router.NavigateAndReset.Execute(
				new GenerateWalletPasswordViewModel(screen, this, "Create Wallet", cancel, home));
		}

		public RoutingState Router { get; } = new RoutingState();

		public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

		public ICommand ShowCommand { get; }

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
