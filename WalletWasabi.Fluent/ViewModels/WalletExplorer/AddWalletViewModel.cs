using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletExplorer
{
	public class AddWalletViewModel : RoutableViewModel
	{
		private string _name;
		private string _password;
		private string _passwordConfirm;
		private string[] _recovery;

		public AddWalletViewModel(IScreen screen, string title) : base(screen, "Wallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
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

		public string[] Recovery
		{
			get => _recovery;
			set => this.RaiseAndSetIfChanged(ref _recovery, value);
		}
	}
}
