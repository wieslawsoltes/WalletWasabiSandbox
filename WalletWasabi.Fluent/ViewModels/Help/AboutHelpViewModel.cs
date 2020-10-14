using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
    public class AboutHelpViewModel : RoutableViewModel
	{
		public AboutHelpViewModel(IScreen screen, string title) : base(screen, "AboutHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
