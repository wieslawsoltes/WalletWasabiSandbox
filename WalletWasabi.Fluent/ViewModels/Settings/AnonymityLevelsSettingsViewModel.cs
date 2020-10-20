using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class AnonymityLevelsSettingsViewModel : RoutableViewModel
	{
		public AnonymityLevelsSettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "AnonymityLevelsSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
