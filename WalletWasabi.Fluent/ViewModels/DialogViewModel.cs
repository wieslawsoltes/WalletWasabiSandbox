using System;
using System.Reactive.Linq;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels
{
	public class DialogViewModel : ReactiveObject, IScreen
	{
		private bool _isDialogVisible;

		public DialogViewModel()
		{
			Observable.FromEventPattern(Router.NavigationStack, nameof(Router.NavigationStack.CollectionChanged))
				.Subscribe(_ => IsDialogVisible = Router.NavigationStack.Count >= 1);
		}

		public RoutingState Router { get; } = new RoutingState();

		public bool IsDialogVisible
		{
			get => _isDialogVisible;
			set => this.RaiseAndSetIfChanged(ref _isDialogVisible, value);
		}
	}
}
