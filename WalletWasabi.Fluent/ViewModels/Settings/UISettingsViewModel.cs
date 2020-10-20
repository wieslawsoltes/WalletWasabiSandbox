using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class UISettingsViewModel : RoutableViewModel
	{
		public UISettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "UISettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
