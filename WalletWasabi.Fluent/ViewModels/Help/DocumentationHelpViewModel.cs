using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
	public class DocumentationHelpViewModel : RoutableViewModel
	{
		public DocumentationHelpViewModel(NavigationState navigationState, string title) : base(navigationState, "DocumentationHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
