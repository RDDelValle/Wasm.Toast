using Microsoft.AspNetCore.Components;

namespace Wasm.Toast;

public interface IToastManager
{
    event EventHandler<CreateToastEventArgs> OnCreateToast;
    ValueTask CreateToastAsync(string title, string message);
}

internal class ToastManager : IToastManager
{
    private EventHandler<CreateToastEventArgs>? _onCreateToast;
    public event EventHandler<CreateToastEventArgs> OnCreateToast
    {
        add => _onCreateToast += value;
        remove => _onCreateToast -= value;
    }

    public ValueTask CreateToastAsync(string title, string message)
    {
        _onCreateToast?.Invoke(this, new CreateToastEventArgs(new ToastModel(title, message)));
        return ValueTask.CompletedTask;
    }
}