using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
	public class BitcoinSettingsViewModel : RoutableViewModel
	{
		public BitcoinSettingsViewModel(NavigationState navigationState, string title) : base(navigationState, "BitcoinSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
