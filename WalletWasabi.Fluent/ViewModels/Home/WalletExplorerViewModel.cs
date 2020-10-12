using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class WalletExplorerViewModel : RoutableViewModel
	{
		public WalletExplorerViewModel(IScreen screen) : base(screen, "WalletExplorer", "Wallet Explorer")
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
