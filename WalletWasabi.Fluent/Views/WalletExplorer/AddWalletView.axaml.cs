using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletExplorer;

namespace WalletWasabi.Fluent.Views.WalletExplorer
{
	public class AddWalletView : ReactiveUserControl<AddWalletViewModel>
	{
		public AddWalletView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
