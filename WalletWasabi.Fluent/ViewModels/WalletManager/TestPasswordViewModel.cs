using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
	public class TestPasswordViewModel : RoutableViewModel
	{
		public TestPasswordViewModel(NavigationState navigationState, string title) : base(navigationState, "TestPassword", title)
		{
#if !USE_DIALOG
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
#else
			ShowCommand = ReactiveCommand.Create(() => navigationState.Dialog().Router.Navigate.Execute(this));
#endif
		}

		public ICommand ShowCommand { get; }
	}
}
