using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class TorSettingsViewModel : RoutableViewModel
	{
		public TorSettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "TorSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
