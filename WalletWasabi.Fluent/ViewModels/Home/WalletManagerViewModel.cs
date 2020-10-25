using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;
using WalletWasabi.Fluent.ViewModels.WalletManager;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class WalletManagerViewModel : RoutableViewModel
	{
		private string _name;
		private ObservableCollection<RoutableViewModel> _items;
		private ObservableCollection<RoutableViewModel> _wallets;
		private RoutableViewModel _home;

		public WalletManagerViewModel(NavigationStateViewModel navigationState, string title) : base(navigationState, "WalletManager", title)
		{
#if !USE_DIALOG
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
#else
			ShowCommand = ReactiveCommand.Create(() => navigationState.Dialog().Router.Navigate.Execute(this));
#endif

			var navigationStateWalletManager = new NavigationStateViewModel()
			{
				Screen = () => navigationState.Screen(),
				Dialog = () => navigationState.Dialog(),
				NextView = () => _home,
				CancelView = () => _home,
			};

			_items = new ObservableCollection<RoutableViewModel>
			{
				new GenerateWalletViewModel(navigationStateWalletManager, "Create new Wallet", this),
				new RecoverWalletViewModel(navigationStateWalletManager, "Recover Wallet"),
				new LoadWalletViewModel(navigationStateWalletManager, "Import Wallet"),
				new TestPasswordViewModel(navigationStateWalletManager, "Test Password"),
				new HardwareWalletViewModel(navigationStateWalletManager, "Connect HW Wallet")
			};

			_wallets = new ObservableCollection<RoutableViewModel>
			{
				new WalletViewModel(navigationStateWalletManager, "Random Wallet (0 BTC)"),
				new WalletViewModel(navigationStateWalletManager, "Random Wallet 2 (0 BTC)"),
				new WalletViewModel(navigationStateWalletManager, "Random Wallet 3 (0 BTC)"),
				new WalletViewModel(navigationStateWalletManager, "Random Wallet 4 (0 BTC)")
			};
		}

		public ICommand ShowCommand { get; }

		public string Name
		{
			get => _name;
			set => this.RaiseAndSetIfChanged(ref _name, value);
		}

		public ObservableCollection<RoutableViewModel> Items
		{
			get => _items;
			set => this.RaiseAndSetIfChanged(ref _items, value);
		}

		public ObservableCollection<RoutableViewModel> Wallets
		{
			get => _wallets;
			set => this.RaiseAndSetIfChanged(ref _wallets, value);
		}

		public RoutableViewModel Home
		{
			get => _home;
			set => this.RaiseAndSetIfChanged(ref _home, value);
		}
	}
}
