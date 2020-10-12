using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using WalletWasabi.Fluent.ViewModels.Home;

namespace WalletWasabi.Fluent.Views.Home
{
	public class TransactionBroadcasterView : ReactiveUserControl<TransactionBroadcasterViewModel>
	{
		public TransactionBroadcasterView()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
