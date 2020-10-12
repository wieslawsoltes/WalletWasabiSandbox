using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class WalletExplorerViewModel : RoutableViewModel
	{
		private ObservableCollection<RoutableViewModel> _wallets;

		public WalletExplorerViewModel(IScreen screen) : base(screen, "WalletExplorer", "Wallet Explorer")
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));

			_wallets = new ObservableCollection<RoutableViewModel>
			{
				new WalletViewModel(screen, "Random Wallet (0 BTC)"),
				new WalletViewModel(screen, "Random Wallet 2 (0 BTC)"),
				new WalletViewModel(screen, "Random Wallet 3 (0 BTC)"),
				new WalletViewModel(screen, "Random Wallet 4 (0 BTC)"),
				new AddWalletViewModel(screen, "Add Wallet"),
			};
		}

		public ICommand ShowCommand { get; }

		public ObservableCollection<RoutableViewModel> Wallets
		{
			get => _wallets;
			set => this.RaiseAndSetIfChanged(ref _wallets, value);
		}
	}
}
