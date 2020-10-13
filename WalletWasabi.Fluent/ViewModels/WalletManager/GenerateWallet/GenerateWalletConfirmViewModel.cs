using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletConfirmViewModel : RoutableViewModel
	{
		private RoutableViewModel _cancel;
		private RoutableViewModel _finish;
		private string[] _recoveryWords;

		public GenerateWalletConfirmViewModel(IScreen screen, string title, RoutableViewModel cancel) : base(screen, "GenerateWalletPassword", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(_cancel));
			FinishCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(_cancel));
			_cancel = cancel;
			_finish = cancel;
		}

		public ICommand ShowCommand { get; }

		public ICommand CancelCommand { get; }

		public ICommand FinishCommand { get; }

		public string[] RecoveryWords
		{
			get => _recoveryWords;
			set => this.RaiseAndSetIfChanged(ref _recoveryWords, value);
		}
	}
}
