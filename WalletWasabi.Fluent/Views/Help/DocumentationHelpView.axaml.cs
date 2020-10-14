using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Help;

namespace WalletWasabi.Fluent.Views.Help
{
	public class DocumentationHelpView : ReactiveUserControl<DocumentationHelpViewModel>
	{
		public DocumentationHelpView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
