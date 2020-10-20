using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class OtherSettingsSettingsViewModel : RoutableViewModel
	{
		public OtherSettingsSettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "OtherSettingsSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
