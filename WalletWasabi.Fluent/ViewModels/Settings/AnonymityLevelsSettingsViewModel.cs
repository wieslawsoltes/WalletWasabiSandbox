using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.Settings
{
    public class AnonymityLevelsSettingsViewModel : RoutableViewModel
	{
		public AnonymityLevelsSettingsViewModel(IScreen screen, string title) : base(screen, "AnonymityLevelsSettings", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
