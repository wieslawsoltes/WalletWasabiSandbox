using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
	public class HardwareWalletViewModel : RoutableViewModel
	{
		public HardwareWalletViewModel(NavigationState navigationState, string title) : base(navigationState, "HardwareWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
