using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager;

namespace WalletWasabi.Fluent.ViewModels.WalletExplorer
{
    public class WalletManagerViewModel : RoutableViewModel
	{
		private string _name;
		private ObservableCollection<RoutableViewModel> _items;

		public WalletManagerViewModel(IScreen screen, string title) : base(screen, "Wallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));

			_items = new ObservableCollection<RoutableViewModel>
			{
				new GenerateWalletViewModel(screen, "Add Wallet", ""),
				new RecoverWalletViewModel(screen, "Recover Wallet"),
				new LoadWalletViewModel(screen, "Import Wallet"),
				new TestPasswordViewModel(screen, "Test Password"),
				new HardwareWalletViewModel(screen, "Connect HW Wallet")
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
	}
}
