using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
	public class ReportBugHelpViewModel : RoutableViewModel
	{
		public ReportBugHelpViewModel(NavigationState navigationState, string title) : base(navigationState, "ReportBugHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
