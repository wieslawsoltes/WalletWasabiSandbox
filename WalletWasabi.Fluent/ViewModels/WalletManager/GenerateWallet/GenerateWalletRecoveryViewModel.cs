using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletRecoveryViewModel : RoutableViewModel
	{
		private RoutableViewModel _cancel;
		private RoutableViewModel _next;
		private string[] _recoveryWords;

		public GenerateWalletRecoveryViewModel(IScreen wizard, string title, RoutableViewModel cancel) : base(wizard, "GenerateWalletRecovery", title)
		{
			ShowCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(_cancel));
			NextCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(_next));
			_cancel = cancel;
			_next = new GenerateWalletConfirmViewModel(wizard, "Create Wallet", cancel);
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
