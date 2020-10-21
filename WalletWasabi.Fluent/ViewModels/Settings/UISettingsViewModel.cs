using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class UISettingsViewModel : RoutableViewModel
	{
		public UISettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "UISettings", title)
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
