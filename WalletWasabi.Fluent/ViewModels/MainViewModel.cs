using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels
{
	public class MainViewModel : ReactiveObject, IScreen
	{
		private DialogViewModel _dialog;

		public MainViewModel()
		{
			var navigationState = new NavigationState();

			var walletManager = new WalletManagerViewModel(navigationState, "Add Wallet");
			var helpViewModel = new HelpViewModel(navigationState);
			var walletExplorerViewModel = new WalletExplorerViewModel(navigationState, walletManager);
			var settingsViewModel = new SettingsViewModel(navigationState);

			HomeCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.NavigateAndReset.Execute(walletExplorerViewModel));

			HelpCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(helpViewModel));

#if !USE_DIALOG
			AddWalletCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(walletManager));
#else
			AddWalletCommand = ReactiveCommand.Create(() => navigationState.Dialog().Router.Navigate.Execute(walletManager));
#endif

			SettingsCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(settingsViewModel));

			_dialog = new DialogViewModel();

			walletManager.Home = walletExplorerViewModel;

			navigationState.Screen = () => this;
			navigationState.Dialog = () => _dialog;
			navigationState.HomeView = () => walletExplorerViewModel;
			navigationState.CancelView = () => walletExplorerViewModel;

			Router.NavigateAndReset.Execute(walletExplorerViewModel);

			// Router.NavigateAndReset.Execute(new HomeViewModel(this));
		}

		public RoutingState Router { get; } = new RoutingState();

		public DialogViewModel Dialog
		{
			get => _dialog;
			set => this.RaiseAndSetIfChanged(ref _dialog, value);
		}

		public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

		public ICommand HomeCommand { get; }

		public ICommand HelpCommand { get; }

		public ICommand AddWalletCommand { get; }

		public ICommand SettingsCommand { get; }
	}
}
