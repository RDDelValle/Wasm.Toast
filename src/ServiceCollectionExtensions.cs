using Microsoft.Extensions.DependencyInjection;

namespace Wasm.Toast;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWasmToast(this IServiceCollection services, IToastConfig? config = null)
    {
        config ??= new ToastConfig(ToastPosition.BottomEnd);
        services.AddSingleton<IToastConfig>(config);
        services.AddScoped<IToastManager, ToastManager>();
        return services;
    }
}