using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager;

namespace WalletWasabi.Fluent.Views.WalletManager
{
	public class RecoverWalletView : ReactiveUserControl<RecoverWalletView>
	{
		public RecoverWalletView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
