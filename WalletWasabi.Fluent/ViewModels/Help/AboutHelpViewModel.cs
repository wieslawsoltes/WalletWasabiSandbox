using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
	public class AboutHelpViewModel : RoutableViewModel
	{
		public AboutHelpViewModel(NavigationState navigationState, string title) : base(navigationState, "AboutHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
