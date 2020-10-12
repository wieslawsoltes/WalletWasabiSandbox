using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels;

namespace WalletWasabi.Fluent.Views
{
	public class HomeView : ReactiveUserControl<HomeViewModel>
	{
		public HomeView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
