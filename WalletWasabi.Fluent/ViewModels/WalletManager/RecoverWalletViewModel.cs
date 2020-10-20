using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
	public class RecoverWalletViewModel : RoutableViewModel
	{
		public RecoverWalletViewModel(NavigationState navigationState, string title) : base(navigationState, "RecoverWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
