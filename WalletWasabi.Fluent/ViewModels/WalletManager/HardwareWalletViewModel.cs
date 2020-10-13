using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
    public class HardwareWalletViewModel : RoutableViewModel
	{
		public HardwareWalletViewModel(IScreen screen, string title) : base(screen, "HardwareWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
