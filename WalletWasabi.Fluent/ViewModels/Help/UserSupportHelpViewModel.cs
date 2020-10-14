using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Help
{
    public class UserSupportHelpViewModel : RoutableViewModel
	{
		public UserSupportHelpViewModel(IScreen screen, string title) : base(screen, "UserSupportHelp", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
