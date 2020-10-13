using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager;

namespace WalletWasabi.Fluent.Views.WalletManager
{
	public class HardwareWalletView : ReactiveUserControl<HardwareWalletViewModel>
	{
		public HardwareWalletView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
