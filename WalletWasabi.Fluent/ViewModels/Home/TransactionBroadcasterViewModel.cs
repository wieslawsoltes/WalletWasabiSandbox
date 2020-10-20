using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class TransactionBroadcasterViewModel : RoutableViewModel
	{
		public TransactionBroadcasterViewModel(NavigationState navigationState) : base(navigationState, "TransactionBroadcaster", "Transaction Broadcaster")
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
