using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class LockScreenSettingsViewModel : RoutableViewModel
	{
		public LockScreenSettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "LockScreenSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
