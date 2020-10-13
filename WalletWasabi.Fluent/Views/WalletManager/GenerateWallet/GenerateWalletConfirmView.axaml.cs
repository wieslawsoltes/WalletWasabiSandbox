using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet;

namespace WalletWasabi.Fluent.Views.WalletManager.GenerateWallet
{
	public class GenerateWalletConfirmView : ReactiveUserControl<GenerateWalletConfirmViewModel>
	{
		public GenerateWalletConfirmView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
