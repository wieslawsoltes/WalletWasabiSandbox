using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
	public class LegalDocumentHelpViewModel : RoutableViewModel
	{
		public LegalDocumentHelpViewModel(NavigationState navigationState, string title) : base(navigationState, "LegalDocumentHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
