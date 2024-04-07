namespace Wasm.Toast;

public interface IToast
{
    Task CloseToastAsync(string id);
}