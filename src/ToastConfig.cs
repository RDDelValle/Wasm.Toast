namespace Wasm.Toast;

internal class ToastConfig(ToastPosition position) : IToastConfig
{
    public ToastPosition Position { get; } = position;
}