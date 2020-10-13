using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
    public class TestPasswordViewModel : RoutableViewModel
	{
		public TestPasswordViewModel(IScreen screen, string title) : base(screen, "TestPassword", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
