namespace MvvmArchitecture.Interfaces;

public interface IContext
{
    void Send(SendOrPostCallback callback);
}