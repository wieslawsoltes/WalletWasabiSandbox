using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Windows.Input;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class WalletExplorerViewModel : RoutableViewModel
	{
		private ReadOnlyObservableCollection<RoutableViewModel> _items;

		public WalletExplorerViewModel(NavigationState navigationState, WalletManagerViewModel walletManager) : base(navigationState, "WalletExplorer", "Wallet Explorer")
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));

			var navigationStateWalletExplorer = new NavigationState()
			{
				Screen = () => navigationState.Screen(),
				HomeView = () => this,
				CancelView = () => this,
			};

			var list = new SourceList<RoutableViewModel>();
			list.Add(new AddWalletViewModel(navigationStateWalletExplorer, "Add Wallet", walletManager));

			walletManager.Wallets.ToObservableChangeSet()
				.Merge(list.Connect())
				.Bind(out _items)
				.AsObservableList();
		}

		public ICommand ShowCommand { get; }

		public ReadOnlyObservableCollection<RoutableViewModel> Items => _items;
	}
}
