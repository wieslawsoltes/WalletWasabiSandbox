using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels
{
	public abstract class RoutableViewModel : ReactiveObject, IRoutableViewModel
	{
		private string _title;

		public RoutableViewModel(IScreen screen, string urlPathSegment, string title)
		{
			HostScreen = screen;
			UrlPathSegment = urlPathSegment;
			_title = title;
		}

		public IScreen HostScreen { get; }

		public string UrlPathSegment { get; }

		public string Title
		{
			get => _title;
			set => this.RaiseAndSetIfChanged(ref _title, value);
		}
	}
}
