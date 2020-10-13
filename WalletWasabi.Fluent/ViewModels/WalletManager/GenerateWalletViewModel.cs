using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
    public class GenerateWalletPasswordViewModel : RoutableViewModel
	{
		private RoutableViewModel _next;
		private string _password;
		private string _passwordConfirm;

		public GenerateWalletPasswordViewModel(IScreen screen, string title, RoutableViewModel next) : base(screen, "GenerateWalletPassword", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
			NextCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(_next));
			_next = next;
		}

		public ICommand ShowCommand { get; }

		public ICommand NextCommand { get; }

		public string Password
		{
			get => _password;
			set => this.RaiseAndSetIfChanged(ref _password, value);
		}

		public string PasswordConfirm
		{
			get => _passwordConfirm;
			set => this.RaiseAndSetIfChanged(ref _passwordConfirm, value);
		}
	}

    public class GenerateWalletViewModel : RoutableViewModel
	{
		private string _name;
		private string _password;
		private string _passwordConfirm;
		private string[] _mnemonic;

		public GenerateWalletViewModel(IScreen screen, string title, string name) : base(screen, "GenerateWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
			_name = name;
		}

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

		public string PasswordConfirm
		{
			get => _passwordConfirm;
			set => this.RaiseAndSetIfChanged(ref _passwordConfirm, value);
		}

		public string[] Mnemonic
		{
			get => _mnemonic;
			set => this.RaiseAndSetIfChanged(ref _mnemonic, value);
		}
	}
}
