using System.ComponentModel;

namespace MvvmArchitecture;

public static class EventRaiser
{
    public static void Raise(this EventHandler? handler, object sender)
    {
        handler?.Invoke(sender, EventArgs.Empty);
    }

    public static void Raise<T>(this EventHandler<T>? handler, object sender, T args)
    {
        handler?.Invoke(sender, args);
    }

    public static void Raise(this PropertyChangedEventHandler? handler, object sender, string propertyName)
    {
        handler?.Invoke(sender, new PropertyChangedEventArgs(propertyName));
    }
}