using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
	public class UserSupportHelpViewModel : RoutableViewModel
	{
		public UserSupportHelpViewModel(NavigationState navigationState, string title) : base(navigationState, "UserSupportHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
