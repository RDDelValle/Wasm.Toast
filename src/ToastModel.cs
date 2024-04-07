namespace Wasm.Toast;

public class ToastModel(string title, string message, int duration = 10000)
{
    public string Id { get; } = $"toast{Guid.NewGuid().ToString().Replace("-", "")}";
    public string Title { get; } = title;
    public string Message { get; } = message;
    public int Duration { get; } = duration;
}