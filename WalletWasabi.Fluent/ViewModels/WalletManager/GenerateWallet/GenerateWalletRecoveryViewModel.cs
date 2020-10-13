using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet
{
	public class GenerateWalletRecoveryViewModel : RoutableViewModel
	{
		private string[] _recoveryWords;

		public GenerateWalletRecoveryViewModel(IScreen homeScreen, IScreen wizardScreen, string title, RoutableViewModel cancel, RoutableViewModel home) : base(wizardScreen, "GenerateWalletRecovery", title)
		{
			ShowCommand = ReactiveCommand.Create(() => wizardScreen.Router.Navigate.Execute(this));
			CancelCommand = ReactiveCommand.Create(() => homeScreen.Router.Navigate.Execute(cancel));
			NextCommand = ReactiveCommand.Create(() => wizardScreen.Router.Navigate.Execute(
				new GenerateWalletConfirmViewModel(homeScreen, wizardScreen, "Create Wallet", cancel, home)));
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
