using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletConfirmViewModel : RoutableViewModel
	{
		private RoutableViewModel _cancel;
		private RoutableViewModel _next;
		private string[] _recoveryWords;

		public GenerateWalletConfirmViewModel(IScreen wizard, string title, RoutableViewModel cancel) : base(wizard, "GenerateWalletConfirm", title)
		{
			ShowCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(_cancel));
			NextCommand = ReactiveCommand.Create(() => wizard.Router.Navigate.Execute(_cancel));
			_cancel = cancel;
			_next = cancel;
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
