using System.Collections.ObjectModel;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels
{
	public class HomeViewModel : RoutableViewModel
	{
		private ObservableCollection<RoutableViewModel> _items;

		public HomeViewModel(IScreen screen) : base(screen, "Home", "Home")
		{
			_items = new ObservableCollection<RoutableViewModel>
			{
				new WalletExplorerViewModel(screen),
				new WalletManagerViewModel(screen),
				new TransactionBroadcasterViewModel(screen),
				new SettingsViewModel(screen),
				new HelpViewModel(screen)
			};
		}

		public ObservableCollection<RoutableViewModel> Items
		{
			get => _items;
			set => this.RaiseAndSetIfChanged(ref _items, value);
		}
	}
}
