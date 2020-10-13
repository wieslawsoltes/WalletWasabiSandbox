using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletRecoveryViewModel : RoutableViewModel
	{
		private RoutableViewModel _cancel;
		private RoutableViewModel _next;
		private string[] _recoveryWords;

		public GenerateWalletRecoveryViewModel(IScreen screen, string title, RoutableViewModel cancel) : base(screen, "GenerateWalletPassword", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(_cancel));
			NextCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(_next));
			_cancel = cancel;
			_next = new GenerateWalletConfirmViewModel(screen, "Create Wallet", cancel); ;
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
