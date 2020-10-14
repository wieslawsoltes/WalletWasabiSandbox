using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletExplorer
{
    public class WalletViewModel : RoutableViewModel
	{
		public WalletViewModel(IScreen screen, string title) : base(screen, "Wallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
