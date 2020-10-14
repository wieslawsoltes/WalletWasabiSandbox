using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Help;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class HelpViewModel : RoutableViewModel
	{
		private ObservableCollection<RoutableViewModel> _items;

		public HelpViewModel(IScreen screen) : base(screen, "Help", "Help")
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));

			_items = new ObservableCollection<RoutableViewModel>
			{
				new AboutHelpViewModel(screen, "About"),
				new UserSupportHelpViewModel(screen, "User Support"),
				new ReportBugHelpViewModel(screen, "Report Bug"),
				new DocumentationHelpViewModel(screen, "Documentation"),
				new LegalDocumentHelpViewModel(screen, "Legal Document")
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
