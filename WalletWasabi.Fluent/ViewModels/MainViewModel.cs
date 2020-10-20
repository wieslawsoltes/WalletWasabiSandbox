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
			var navigationState = new NavigationState();

			var walletManager = new WalletManagerViewModel(navigationState, "Add Wallet");
			var helpViewModel = new HelpViewModel(navigationState);
			var walletExplorerViewModel = new WalletExplorerViewModel(navigationState, walletManager);
			var settingsViewModel = new SettingsViewModel(navigationState);

			HomeCommand = ReactiveCommand.Create(() => Router.NavigateAndReset.Execute(walletExplorerViewModel));

			HelpCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(helpViewModel));

			AddWalletCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(walletManager));

			SettingsCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(settingsViewModel));

			walletManager.Home = walletExplorerViewModel;

			navigationState.Screen = () => this;
			navigationState.HomeView = () => walletExplorerViewModel;
			navigationState.CancelView = () => walletExplorerViewModel;

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
