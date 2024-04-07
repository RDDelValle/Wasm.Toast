namespace Wasm.Toast;

public class CreateToastEventArgs(ToastModel model) : EventArgs
{
    public ToastModel Model { get; } = model;
}