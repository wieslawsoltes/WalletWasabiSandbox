using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.WalletManager;

namespace WalletWasabi.Fluent.Views.WalletManager
{
	public class LoadWalletView : ReactiveUserControl<LoadWalletViewModel>
	{
		public LoadWalletView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
