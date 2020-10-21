using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class TorSettingsViewModel : RoutableViewModel
	{
		public TorSettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "TorSettings", title)
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
