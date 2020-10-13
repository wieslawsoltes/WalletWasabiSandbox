using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager.GenerateWallet;

namespace WalletWasabi.Fluent.Views.WalletManager.GenerateWallet
{
	public class GenerateWalletPasswordView : ReactiveUserControl<GenerateWalletPasswordViewModel>
	{
		public GenerateWalletPasswordView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
