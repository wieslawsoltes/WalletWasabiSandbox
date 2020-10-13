using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels
{
	public class MainViewModel : ReactiveObject, IScreen
	{
		public MainViewModel()
		{
			var helpViewModel = new HelpViewModel(this);
			var walletExplorerViewModel = new WalletExplorerViewModel(this);
			var walletManagerViewModel = new WalletManagerViewModel(this, "Add Wallet", walletExplorerViewModel);
			var settingsViewModel = new SettingsViewModel(this);

			HelpCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(helpViewModel));
			AddWalletCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(walletManagerViewModel));
			SettingsCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(settingsViewModel));

			//Router.NavigateAndReset.Execute(new HomeViewModel(this));
			Router.NavigateAndReset.Execute(walletExplorerViewModel);
		}

		public RoutingState Router { get; } = new RoutingState();

		public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

		public ICommand HelpCommand { get; }

		public ICommand AddWalletCommand { get; }

		public ICommand SettingsCommand { get; }
	}
}
