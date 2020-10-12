using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels;

namespace WalletWasabi.Fluent.Views
{
	public class MainView : ReactiveUserControl<MainViewModel>
	{
		public MainView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
