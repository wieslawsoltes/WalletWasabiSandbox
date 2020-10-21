using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class OtherSettingsSettingsViewModel : RoutableViewModel
	{
		public OtherSettingsSettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "OtherSettingsSettings", title)
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
