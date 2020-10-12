using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;

namespace WalletWasabi.Fluent.Views.WalletExplorer
{
	public class WalletView : ReactiveUserControl<WalletViewModel>
	{
		public WalletView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
