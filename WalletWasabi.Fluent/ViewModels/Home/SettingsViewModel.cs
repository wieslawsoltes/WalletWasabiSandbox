using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Settings;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class SettingsViewModel : RoutableViewModel
	{
		private ObservableCollection<RoutableViewModel> _items;

		public SettingsViewModel(IScreen screen) : base(screen, "Settings", "Settings")
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));

			_items = new ObservableCollection<RoutableViewModel>
			{
				new BitcoinSettingsViewModel(screen, "Bitcoin"),
				new TorSettingsViewModel(screen, "Tor"),
				new UISettingsViewModel(screen, "UI"),
				new LockScreenSettingsViewModel(screen, "Lock Screen"),
				new AnonymityLevelsSettingsViewModel(screen, "Anonymity Levels"),
				new OtherSettingsSettingsViewModel(screen, "Other Settings")
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
