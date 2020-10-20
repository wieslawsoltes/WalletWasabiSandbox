using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
	public class LoadWalletViewModel : RoutableViewModel
	{
		public LoadWalletViewModel(NavigationState navigationState, string title) : base(navigationState, "LoadWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
