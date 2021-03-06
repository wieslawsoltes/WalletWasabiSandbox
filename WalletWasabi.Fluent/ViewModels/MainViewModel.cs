using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels
{
	public class MainViewModel : ReactiveObject, IScreen
	{
		private DialogViewModel _dialog;
		private WalletManagerViewModel _walletManager;

		public MainViewModel()
		{
			var navigationState = new NavigationStateViewModel();

			_dialog = new DialogViewModel();
			_walletManager = new WalletManagerViewModel(navigationState, "Add Wallet");

			var helpViewModel = new HelpViewModel(navigationState);
			var walletExplorerViewModel = new WalletExplorerViewModel(navigationState, _walletManager);
			var settingsViewModel = new SettingsViewModel(navigationState);

			HomeCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.NavigateAndReset.Execute(walletExplorerViewModel));

#if !USE_DIALOG
			HelpCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(helpViewModel));
#else
			HelpCommand = ReactiveCommand.Create(() => navigationState.Dialog().Router.Navigate.Execute(helpViewModel));
#endif

#if !USE_DIALOG
			AddWalletCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(walletManager));
#else
			AddWalletCommand = ReactiveCommand.Create(() => navigationState.Dialog().Router.Navigate.Execute(_walletManager));
#endif

#if !USE_DIALOG
			SettingsCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(settingsViewModel));
#else
			SettingsCommand = ReactiveCommand.Create(() => navigationState.Dialog().Router.Navigate.Execute(settingsViewModel));
#endif
			_walletManager.Home = walletExplorerViewModel;

			navigationState.Screen = () => this;
			navigationState.Dialog = () => _dialog;
			navigationState.NextView = () => walletExplorerViewModel;
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

		public WalletManagerViewModel WalletManager
		{
			get => _walletManager;
			set => this.RaiseAndSetIfChanged(ref _walletManager, value);
		}

		public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

		public ICommand HomeCommand { get; }

		public ICommand HelpCommand { get; }

		public ICommand AddWalletCommand { get; }

		public ICommand SettingsCommand { get; }
	}
}
