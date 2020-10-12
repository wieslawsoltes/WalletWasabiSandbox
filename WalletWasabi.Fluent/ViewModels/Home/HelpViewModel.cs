using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class HelpViewModel : RoutableViewModel
	{
		public HelpViewModel(IScreen screen) : base(screen, "Help", "Help")
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
