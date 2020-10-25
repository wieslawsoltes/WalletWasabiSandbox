using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class AnonymityLevelsSettingsViewModel : RoutableViewModel
	{
		public AnonymityLevelsSettingsViewModel(NavigationStateViewModel navigationState, string title) : base(navigationState, "AnonymityLevelsSettings", title)
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
