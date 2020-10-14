using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
    public class DocumentationHelpViewModel : RoutableViewModel
	{
		public DocumentationHelpViewModel(IScreen screen, string title) : base(screen, "DocumentationHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
