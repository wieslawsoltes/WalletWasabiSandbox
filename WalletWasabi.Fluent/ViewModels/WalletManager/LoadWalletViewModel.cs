using System.Windows.Input;
using ReactiveUI;

namespace WalletWasabi.Fluent.ViewModels.WalletManager
{
    public class LoadWalletViewModel : RoutableViewModel
	{
		public LoadWalletViewModel(IScreen screen, string title) : base(screen, "LoadWallet", title)
		{
			ShowCommand = ReactiveCommand.Create(() => screen.Router.Navigate.Execute(this));
		}

		public ICommand ShowCommand { get; }
	}
}
