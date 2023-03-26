using MvvmArchitecture.Interfaces;
using System.Threading;
using System.Windows;
using GapTraderCore.ViewModels;
using MvvmArchitecture;

namespace GapTraderWpf;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var context = GetDispatcherContext();
        var runner = new Runner(context);
        
        Window window = new MainWindow();
        window.Show();
        window.DataContext = new RootViewModel(runner);
    }

    private IContext GetDispatcherContext()
    {
        var dispatcherContext = Dispatcher?.Invoke(() => SynchronizationContext.Current);

        if (dispatcherContext == null)
            throw new ThreadStateException("Could not get dispatcher synchronisation context.");

        var context = new Context(dispatcherContext);
        return context;
    }
}