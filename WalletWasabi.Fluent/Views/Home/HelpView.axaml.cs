using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.Views.Home
{
	public class HelpView : ReactiveUserControl<HelpViewModel>
	{
		public HelpView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
