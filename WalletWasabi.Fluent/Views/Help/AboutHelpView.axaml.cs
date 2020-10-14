using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Help;

namespace WalletWasabi.Fluent.Views.Help
{
	public class AboutHelpView : ReactiveUserControl<AboutHelpViewModel>
	{
		public AboutHelpView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
