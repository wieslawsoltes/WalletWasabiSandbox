using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletConfirmViewModel : RoutableViewModel
	{
		private string[] _recoveryWords;

		public GenerateWalletConfirmViewModel(IScreen homeScreen, IScreen wizardScreen, string title, RoutableViewModel cancel, RoutableViewModel home) : base(wizardScreen, "GenerateWalletConfirm", title)
		{
			ShowCommand = ReactiveCommand.Create(() => wizardScreen.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => homeScreen.Router.Navigate.Execute(cancel));
			NextCommand = ReactiveCommand.Create(() => homeScreen.Router.NavigateAndReset.Execute(home));
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
