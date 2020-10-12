using Avalonia;
using Avalonia.ReactiveUI;

namespace WalletWasabi.Fluent
{
	internal class Program
	{
		public static void Main(string[] args) => BuildAvaloniaApp()
			.StartWithClassicDesktopLifetime(args);

		public static AppBuilder BuildAvaloniaApp()
		{
			return AppBuilder.Configure<App>()
				.UsePlatformDetect()
				.UseReactiveUI()
				.LogToDebug();
		}
	}
}
