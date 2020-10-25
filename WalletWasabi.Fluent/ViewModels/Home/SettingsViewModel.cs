using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Settings;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class SettingsViewModel : RoutableViewModel
	{
		private ObservableCollection<RoutableViewModel> _items;

		public SettingsViewModel(NavigationStateViewModel navigationState) : base(navigationState, "Settings", "Settings")
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));

			_items = new ObservableCollection<RoutableViewModel>
			{
				new BitcoinSettingsViewModel(navigationState, "Bitcoin"),
				new TorSettingsViewModel(navigationState, "Tor"),
				new UISettingsViewModel(navigationState, "UI"),
				new LockScreenSettingsViewModel(navigationState, "Lock Screen"),
				new AnonymityLevelsSettingsViewModel(navigationState, "Anonymity Levels"),
				new OtherSettingsSettingsViewModel(navigationState, "Other Settings")
			};
		}

		public ICommand ShowCommand { get; }

		public ObservableCollection<RoutableViewModel> Items
		{
			get => _items;
			set => this.RaiseAndSetIfChanged(ref _items, value);
		}
	}
}
