using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
    public class LegalDocumentHelpViewModel : RoutableViewModel
	{
		public LegalDocumentHelpViewModel(IScreen screen, string title) : base(screen, "LegalDocumentHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
