using System.Collections.ObjectModel;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels
{
	public class HomeViewModel : RoutableViewModel
	{
		private ObservableCollection<RoutableViewModel> _items;

		public HomeViewModel(NavigationState navigationState, WalletManagerViewModel walletManager) : base(navigationState, "Home", "Home")
		{
			_items = new ObservableCollection<RoutableViewModel>
			{
				new WalletExplorerViewModel(navigationState, walletManager),
				walletManager,
				new TransactionBroadcasterViewModel(navigationState),
				new SettingsViewModel(navigationState),
				new HelpViewModel(navigationState)
			};
		}

		public ObservableCollection<RoutableViewModel> Items
		{
			get => _items;
			set => this.RaiseAndSetIfChanged(ref _items, value);
		}
	}
}
