using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Help;

namespace WalletWasabi.Fluent.Views.Help
{
	public class LegalDocumentHelpView : ReactiveUserControl<LegalDocumentHelpViewModel>
	{
		public LegalDocumentHelpView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
