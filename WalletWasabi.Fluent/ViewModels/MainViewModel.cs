using System.Reactive;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels
{
	public class MainViewModel : ReactiveObject, IScreen
	{
		public MainViewModel()
		{
			Router.NavigateAndReset.Execute(new HomeViewModel(this));
		}

		public RoutingState Router { get; } = new RoutingState();

		public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;
	}
}
