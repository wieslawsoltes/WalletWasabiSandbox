using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
    public class ReportBugHelpViewModel : RoutableViewModel
	{
		public ReportBugHelpViewModel(IScreen screen, string title) : base(screen, "ReportBugHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
