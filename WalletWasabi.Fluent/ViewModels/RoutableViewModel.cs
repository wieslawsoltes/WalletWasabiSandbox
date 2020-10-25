using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels
{
	public abstract class RoutableViewModel : ReactiveObject, IRoutableViewModel
	{
		private NavigationStateViewModel _navigationState;
		private string _title;

		public RoutableViewModel(NavigationStateViewModel navigationState, string urlPathSegment, string title)
		{
			_navigationState = navigationState;
			UrlPathSegment = urlPathSegment;
			_title = title;
		}

		public IScreen HostScreen => _navigationState.Screen();

		public string UrlPathSegment { get; }

		public string Title
		{
			get => _title;
			set => this.RaiseAndSetIfChanged(ref _title, value);
		}
	}
}
