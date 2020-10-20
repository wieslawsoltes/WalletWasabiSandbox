using System;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels
{
	public class NavigationState
	{
		public Func<IScreen> Screen { get; set; }
		public Func<IRoutableViewModel> CancelView { get; set; }
		public Func<IRoutableViewModel> HomeView { get; set; }
	}
}
