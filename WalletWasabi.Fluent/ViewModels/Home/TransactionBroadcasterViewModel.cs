using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class TransactionBroadcasterViewModel : RoutableViewModel
	{
		public TransactionBroadcasterViewModel(IScreen screen) : base(screen, "TransactionBroadcaster", "Transaction Broadcaster")
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
