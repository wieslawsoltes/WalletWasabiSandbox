using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
	public class LegalDocumentHelpViewModel : RoutableViewModel
	{
		public LegalDocumentHelpViewModel(NavigationStateViewModel navigationState, string title) : base(navigationState, "LegalDocumentHelp", title)
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
