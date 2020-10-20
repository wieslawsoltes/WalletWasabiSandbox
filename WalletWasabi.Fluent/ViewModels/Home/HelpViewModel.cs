using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Help;

namespace WalletWasabi.Fluent.ViewModels.Home
{
	public class HelpViewModel : RoutableViewModel
	{
		private ObservableCollection<RoutableViewModel> _items;

		public HelpViewModel(NavigationState navigationState) : base(navigationState, "Help", "Help")
		{
			ShowCommand = ReactiveCommand.Create(() => navigationState.Screen().Router.Navigate.Execute(this));

			_items = new ObservableCollection<RoutableViewModel>
			{
				new AboutHelpViewModel(navigationState, "About"),
				new UserSupportHelpViewModel(navigationState, "User Support"),
				new ReportBugHelpViewModel(navigationState, "Report Bug"),
				new DocumentationHelpViewModel(navigationState, "Documentation"),
				new LegalDocumentHelpViewModel(navigationState, "Legal Document")
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
