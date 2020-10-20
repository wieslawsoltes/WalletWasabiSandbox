using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
	public class TestPasswordViewModel : RoutableViewModel
	{
		public TestPasswordViewModel(NavigationState navigationState, string title) : base(navigationState, "TestPassword", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
