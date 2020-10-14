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
			var settingsViewModel = new SettingsViewModel(this);

			HomeCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(walletExplorerViewModel));

			HelpCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(helpViewModel));

			AddWalletCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(
				new WalletManagerViewModel(this, "Add Wallet", walletExplorerViewModel)));

			SettingsCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(settingsViewModel));

			Router.NavigateAndReset.Execute(walletExplorerViewModel);

			// Router.NavigateAndReset.Execute(new HomeViewModel(this));
		}

		public RoutingState Router { get; } = new RoutingState();

		public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

		public ICommand HomeCommand { get; }

		public ICommand HelpCommand { get; }

		public ICommand AddWalletCommand { get; }

		public ICommand SettingsCommand { get; }
	}
}
