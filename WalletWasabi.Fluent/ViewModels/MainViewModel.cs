using System.Reactive;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.ViewModels
{
	public class MainViewModel : ReactiveObject, IScreen
	{
		public MainViewModel()
		{
			Router.NavigateAndReset.Execute(new HomeViewModel(this));
			HelpCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(new HelpViewModel(this)));
			AddWalletCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(new WalletManagerViewModel(this, "Add Wallet")));
			SettingsCommand = ReactiveCommand.Create(() => Router.Navigate.Execute(new SettingsViewModel(this)));
		}

		public RoutingState Router { get; } = new RoutingState();

		public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

		public ICommand HelpCommand { get; }

		public ICommand AddWalletCommand { get; }

		public ICommand SettingsCommand { get; }
	}
}
