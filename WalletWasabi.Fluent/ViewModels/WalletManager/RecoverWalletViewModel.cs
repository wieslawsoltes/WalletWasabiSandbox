using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
    public class RecoverWalletViewModel : RoutableViewModel
	{
		public RecoverWalletViewModel(IScreen screen, string title) : base(screen, "RecoverWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
